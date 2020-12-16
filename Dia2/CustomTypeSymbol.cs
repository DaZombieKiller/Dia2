using Dia2.ComInterfaces;

namespace Dia2
{
    public class CustomTypeSymbol : Symbol
    {
        /// <summary>The symbol's original equipment manufacturer (OEM) ID value.</summary>
        /// <remarks>This property applies only to symbols with a <see cref="SymbolTag"/> of <see cref="SymbolTag.CustomType"/>.</remarks>
        public uint OemID => symbol.oemId;

        /// <summary>The original equipment manufacturer (OEM) symbol's ID value.</summary>
        /// <remarks>
        /// <para>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</para>
        /// <para>This property applies only to symbols with a <see cref="SymbolTag"/> of <see cref="SymbolTag.CustomType"/>.</para>
        /// </remarks>
        public uint OemSymbolID => symbol.oemSymbolId;

        internal CustomTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
