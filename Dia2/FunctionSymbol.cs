using Dia2.ComInterfaces;

namespace Dia2
{
    public class FunctionSymbol : Symbol
    {
        /// <summary>Specifies whether the frame pointer is present.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public bool FramePointerPresent => symbol.framePointerPresent;

        /// <summary>Specifies whether the preprocesser directive for a safe buffer is used.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public bool IsSafeBuffers => symbol.isSafeBuffers;

        /// <summary>The ID of the register that holds a base pointer to local variables on the stack.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public uint LocalBasePointerRegisterID => symbol.localBasePointerRegisterId;

        /// <summary>The ID of the register that holds a base pointer to the parameters.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public uint ParamBasePointerRegisterID => symbol.paramBasePointerRegisterId;

        internal FunctionSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
