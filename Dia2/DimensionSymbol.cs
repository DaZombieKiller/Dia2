using Dia2.ComInterfaces;

namespace Dia2
{
    public class DimensionSymbol : Symbol
    {
        internal DimensionSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
