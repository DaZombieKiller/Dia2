using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a virtual table description.</summary>
    public class VTableShapeSymbol : Symbol
    {
        internal VTableShapeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
