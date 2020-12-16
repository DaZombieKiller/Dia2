using Dia2.ComInterfaces;

namespace Dia2
{
    public class BaseInterfaceSymbol : Symbol
    {
        internal BaseInterfaceSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
