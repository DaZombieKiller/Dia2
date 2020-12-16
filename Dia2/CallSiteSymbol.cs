using Dia2.ComInterfaces;

namespace Dia2
{
    public class CallSiteSymbol : Symbol
    {
        internal CallSiteSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
