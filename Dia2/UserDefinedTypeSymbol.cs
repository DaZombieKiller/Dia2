using Dia2.ComInterfaces;

namespace Dia2
{
    public class UserDefinedTypeSymbol : Symbol
    {
        internal UserDefinedTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
