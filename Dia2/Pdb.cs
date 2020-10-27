using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using Dia2.ComInterfaces;

namespace Dia2
{
    public sealed class Pdb : IDisposable
    {
        bool disposed;

        readonly IDiaDataSource source;

        readonly IDiaSession session;

        // Weak references to each IDiaSymbol are held to ensure that when the PDB
        // is disposed, any remaining symbols can be released in order to prevent
        // the input file from being locked.
        readonly ConditionalWeakTable<IDiaSymbol, Symbol> symbols;

        /// <summary>The .pdb file name associated with the last load error.</summary>
        public string LastError
        {
            get
            {
                ThrowIfDisposed();
                return source.lastError;
            }
        }

        /// <summary>A symbol object that represents the global scope.</summary>
        public Symbol GlobalScope
        {
            get
            {
                ThrowIfDisposed();
                return GetOrCreateSymbol(session.globalScope);
            }
        }

        /// <summary>The load address for the executable file that corresponds to the symbols in this symbol store.</summary>
        /// <remarks>Symbol virtual address (VA) properties are computed using the value of this method. Virtual addresses are not calculated unless this property is set to non-zero.</remarks>
        public IntPtr LoadAddress
        {
            get
            {
                ThrowIfDisposed();
                return new IntPtr((long)session.loadAddress);
            }

            set
            {
                ThrowIfDisposed();
                session.loadAddress = (ulong)value.ToInt64();
            }
        }

        public Pdb(string pdbPath)
        {
            symbols = new ConditionalWeakTable<IDiaSymbol, Symbol>();
            source  = DiaSourceFactory.CreateInstance();
            source.loadDataFromPdb(pdbPath);
            session = source.openSession();
        }

        public Pdb(string exePath, string? searchPath)
        {
            symbols = new ConditionalWeakTable<IDiaSymbol, Symbol>();
            source  = DiaSourceFactory.CreateInstance();
            source.loadDataForExe(exePath, searchPath, null);
            session = source.openSession();
        }

        public Pdb(Stream pdb)
        {
            symbols = new ConditionalWeakTable<IDiaSymbol, Symbol>();
            source  = DiaSourceFactory.CreateInstance();
            source.loadDataFromIStream(new ComStream(pdb));
            session = source.openSession();
        }

        public void Close()
        {
            if (disposed)
                return;

            foreach (KeyValuePair<IDiaSymbol, Symbol> pair in symbols)
                Marshal.FinalReleaseComObject(pair.Key);

            Marshal.FinalReleaseComObject(session);
            Marshal.FinalReleaseComObject(source);
            disposed = true;
        }

        void IDisposable.Dispose()
        {
            Close();
        }

        void ThrowIfDisposed()
        {
            if (disposed)
                throw new ObjectDisposedException(typeof(Pdb).FullName);
        }

        [return: NotNullIfNotNull("symbol")]
        internal Symbol? GetOrCreateSymbol(IDiaSymbol? symbol)
        {
            ThrowIfDisposed();

            if (symbol == null)
                return null;

            if (symbols.TryGetValue(symbol, out Symbol? value))
                return value;

            value = new Symbol(this, symbol);
            symbols.Add(symbol, value);
            return value;
        }
    }
}
