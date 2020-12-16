using Dia2.ComInterfaces;

namespace Dia2
{
    public class DataSymbol : Symbol
    {
        internal DataSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
