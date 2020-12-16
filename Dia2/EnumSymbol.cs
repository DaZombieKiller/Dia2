using Dia2.ComInterfaces;

namespace Dia2
{
    public class EnumSymbol : Symbol
    {
        internal EnumSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
