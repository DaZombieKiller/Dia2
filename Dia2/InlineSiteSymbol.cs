using Dia2.ComInterfaces;

namespace Dia2
{
    public class InlineSiteSymbol : Symbol
    {
        internal InlineSiteSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
