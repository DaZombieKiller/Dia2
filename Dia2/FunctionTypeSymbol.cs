using Dia2.ComInterfaces;

namespace Dia2
{
    public class FunctionTypeSymbol : Symbol
    {
        /// <summary>The type of the object pointer for a class method.</summary>
        /// <remarks>This property applies only to symbols with a <see cref="SymbolTag"/> of <see cref="SymbolTag.FunctionType"/>.</remarks>
        public Symbol? ObjectPointerType => pdb.GetOrCreateSymbol(symbol.objectPointerType);

        internal FunctionTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
