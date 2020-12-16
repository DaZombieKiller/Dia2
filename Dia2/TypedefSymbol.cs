using Dia2.ComInterfaces;

namespace Dia2
{
    public class TypedefSymbol : Symbol
    {
        internal TypedefSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
