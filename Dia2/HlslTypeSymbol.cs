using Dia2.ComInterfaces;

namespace Dia2
{
    public class HlslTypeSymbol : Symbol
    {
        /// <summary>A built-in kind of the HLSL type.</summary>
        public uint BuiltInKind => symbol.builtInKind;

        internal HlslTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
