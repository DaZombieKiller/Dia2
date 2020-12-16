using System;
using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A thunk used for sharing data between 16 and 32 bit code.</summary>
    public class ThunkSymbol : Symbol
    {
        /// <summary>The relative virtual address (RVA) of a thunk target.</summary>
        /// <remarks>
        /// <para>This property is valid only if the symbol has a <see cref="SymbolTag"/> value of <see cref="SymbolTag.Thunk"/>.</para>
        /// <para>A "thunk" is a piece of code that converts between a 32-bit memory address space(also known as flat address space) and a 16-bit address space(known as a segmented address space).</para>
        /// </remarks>
        public uint TargetRelativeVirtualAddress => symbol.targetRelativeVirtualAddress;

        /// <summary>The virtual address (VA) of a thunk target.</summary>
        /// <remarks>
        /// <para>This property is valid only if the symbol has a <see cref="SymbolTag"/> value of <see cref="SymbolTag.Thunk"/>.</para>
        /// <para>A "thunk" is a piece of code that converts between a 32-bit memory address space(also known as flat address space) and a 16-bit address space(known as a segmented address space).</para>
        /// </remarks>
        public IntPtr TargetVirtualAddress => new IntPtr((long)symbol.targetVirtualAddress);

        /// <summary>The thunk type of a function.</summary>
        /// <remarks>
        /// <para>This property is valid only if the symbol has a <see cref="SymbolTag"/> value of <see cref="SymbolTag.Thunk"/>.</para>
        /// <para>A "thunk" is a piece of code that converts between a 32-bit memory address space(also known as flat address space) and a 16-bit address space(known as a segmented address space).</para>
        /// </remarks>
        public ThunkOrdinal ThunkOrdinal => symbol.thunkOrdinal;

        internal ThunkSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
