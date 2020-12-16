using Dia2.ComInterfaces;

namespace Dia2
{
    public class VTableSymbol : Symbol
    {
        internal VTableSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
