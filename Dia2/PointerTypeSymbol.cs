using Dia2.ComInterfaces;

namespace Dia2
{
    public class PointerTypeSymbol : Symbol
    {
        internal PointerTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
