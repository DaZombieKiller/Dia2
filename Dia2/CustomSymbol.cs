using Dia2.ComInterfaces;

namespace Dia2
{
    public class CustomSymbol : Symbol
    {
        internal CustomSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
