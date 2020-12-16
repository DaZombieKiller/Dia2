using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a High Level Shader Language (HLSL) type.</summary>
    public class HlslTypeSymbol : Symbol
    {
        /// <summary>The built-in kind of the HLSL type.</summary>
        public uint BuiltInKind => symbol.builtInKind;

        internal HlslTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
