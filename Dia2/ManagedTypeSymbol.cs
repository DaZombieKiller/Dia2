using Dia2.ComInterfaces;

namespace Dia2
{
    public class ManagedTypeSymbol : Symbol
    {
        internal ManagedTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
