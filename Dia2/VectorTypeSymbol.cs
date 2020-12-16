using Dia2.ComInterfaces;

namespace Dia2
{
    public class VectorTypeSymbol : Symbol
    {
        internal VectorTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
