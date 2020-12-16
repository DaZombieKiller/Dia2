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

        // Mapping of IDiaSymbol.symIndexId to Symbol instances. This is done to
        // prevent allocating several Symbol objects for a single DIA symbol.
        readonly Dictionary<uint, Symbol> symbolIdMap;

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
            symbols     = new ConditionalWeakTable<IDiaSymbol, Symbol>();
            symbolIdMap = new Dictionary<uint, Symbol>();
            source      = DiaSourceFactory.CreateInstance();
            source.loadDataFromPdb(pdbPath);
            session = source.openSession();
        }

        public Pdb(string exePath, string? searchPath)
        {
            symbols     = new ConditionalWeakTable<IDiaSymbol, Symbol>();
            symbolIdMap = new Dictionary<uint, Symbol>();
            source      = DiaSourceFactory.CreateInstance();
            source.loadDataForExe(exePath, searchPath, null);
            session = source.openSession();
        }

        public Pdb(Stream pdb)
        {
            symbols     = new ConditionalWeakTable<IDiaSymbol, Symbol>();
            symbolIdMap = new Dictionary<uint, Symbol>();
            source      = DiaSourceFactory.CreateInstance();
            source.loadDataFromIStream(new ComStream(pdb));
            session = source.openSession();
        }

        public void Close()
        {
            if (disposed)
                return;

            foreach (KeyValuePair<IDiaSymbol, Symbol> pair in symbols)
                Marshal.FinalReleaseComObject(pair.Key);

            symbols.Clear();
            symbolIdMap.Clear();

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

        Symbol CreateSymbolWrapper(IDiaSymbol symbol)
        {
            if (symbol is null)
                throw new ArgumentNullException(nameof(symbol));

            return symbol.symTag switch
            {
                SymbolTag.Null             => new Symbol(this, symbol),
                SymbolTag.Exe              => new ExeSymbol(this, symbol),
                SymbolTag.Compiland        => new CompilandSymbol(this, symbol),
                SymbolTag.CompilandDetails => new CompilandDetailsSymbol(this, symbol),
                SymbolTag.CompilandEnv     => new CompilandEnvironmentSymbol(this, symbol),
                SymbolTag.Function         => new FunctionSymbol(this, symbol),
                SymbolTag.Block            => new BlockSymbol(this, symbol),
                SymbolTag.Data             => new DataSymbol(this, symbol),
                SymbolTag.Annotation       => new AnnotationSymbol(this, symbol),
                SymbolTag.Label            => new LabelSymbol(this, symbol),
                SymbolTag.PublicSymbol     => new PublicSymbol(this, symbol),
                SymbolTag.UDT              => new UserDefinedTypeSymbol(this, symbol),
                SymbolTag.Enum             => new EnumSymbol(this, symbol),
                SymbolTag.FunctionType     => new FunctionTypeSymbol(this, symbol),
                SymbolTag.PointerType      => new PointerTypeSymbol(this, symbol),
                SymbolTag.ArrayType        => new ArrayTypeSymbol(this, symbol),
                SymbolTag.BaseType         => new BaseTypeSymbol(this, symbol),
                SymbolTag.Typedef          => new TypedefSymbol(this, symbol),
                SymbolTag.BaseClass        => new BaseClassSymbol(this, symbol),
                SymbolTag.Friend           => new FriendSymbol(this, symbol),
                SymbolTag.FunctionArgType  => new FunctionArgumentTypeSymbol(this, symbol),
                SymbolTag.FuncDebugStart   => new FunctionDebugStartSymbol(this, symbol),
                SymbolTag.FuncDebugEnd     => new FunctionDebugEndSymbol(this, symbol),
                SymbolTag.UsingNamespace   => new UsingNamespaceSymbol(this, symbol),
                SymbolTag.VTableShape      => new VTableShapeSymbol(this, symbol),
                SymbolTag.VTable           => new VTableSymbol(this, symbol),
                SymbolTag.Custom           => new CustomSymbol(this, symbol),
                SymbolTag.Thunk            => new ThunkSymbol(this, symbol),
                SymbolTag.CustomType       => new CustomTypeSymbol(this, symbol),
                SymbolTag.ManagedType      => new ManagedTypeSymbol(this, symbol),
                SymbolTag.Dimension        => new DimensionSymbol(this, symbol),
                SymbolTag.CallSite         => new CallSiteSymbol(this, symbol),
                SymbolTag.InlineSite       => new InlineSiteSymbol(this, symbol),
                SymbolTag.BaseInterface    => new BaseInterfaceSymbol(this, symbol),
                SymbolTag.VectorType       => new VectorTypeSymbol(this, symbol),
                SymbolTag.MatrixType       => new MatrixTypeSymbol(this, symbol),
                SymbolTag.HLSLType         => new HlslTypeSymbol(this, symbol),
                _                          => throw new ArgumentException(null, nameof(symbol)),
            };
        }

        [return: NotNullIfNotNull("symbol")]
        internal Symbol? GetOrCreateSymbol(IDiaSymbol? symbol)
        {
            return GetOrCreateSymbol(symbol, releaseOnError: true);
        }

        [return: NotNullIfNotNull("symbol")]
        internal Symbol? GetOrCreateSymbol(IDiaSymbol? symbol, bool releaseOnError)
        {
            try
            {
                ThrowIfDisposed();

                if (symbol == null)
                    return null;

                if (symbolIdMap.TryGetValue(symbol.symIndexId, out Symbol? value))
                    return value;

                value = CreateSymbolWrapper(symbol);
                symbols.Add(symbol, value);
                symbolIdMap.Add(symbol.symIndexId, value);
                return value;
            }
            catch
            {
                if (releaseOnError && symbol != null)
                    Marshal.ReleaseComObject(symbol);

                throw;
            }
        }
    }
}
