using Dia2.ComInterfaces;

namespace Dia2
{
    public class LabelSymbol : Symbol
    {
        internal LabelSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
