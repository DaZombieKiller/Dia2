using Dia2.ComInterfaces;

namespace Dia2
{
    public class PublicSymbol : Symbol
    {
        internal PublicSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
