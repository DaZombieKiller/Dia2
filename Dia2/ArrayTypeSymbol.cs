using Dia2.ComInterfaces;

namespace Dia2
{
    public class ArrayTypeSymbol : Symbol
    {
        internal ArrayTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
