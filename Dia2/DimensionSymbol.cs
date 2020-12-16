using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a FORTRAN multi-dimensional array.</summary>
    public class DimensionSymbol : Symbol
    {
        internal DimensionSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
