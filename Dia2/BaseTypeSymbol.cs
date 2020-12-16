using Dia2.ComInterfaces;

namespace Dia2
{
    public class BaseTypeSymbol : Symbol
    {
        internal BaseTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
