using Dia2.ComInterfaces;

namespace Dia2
{
    public class BaseClassSymbol : Symbol
    {
        internal BaseClassSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
