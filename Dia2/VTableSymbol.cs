using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a virtual table pointer.</summary>
    public class VTableSymbol : Symbol
    {
        internal VTableSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
