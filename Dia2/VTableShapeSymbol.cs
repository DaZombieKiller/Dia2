using Dia2.ComInterfaces;

namespace Dia2
{
    public class VTableShapeSymbol : Symbol
    {
        internal VTableShapeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
