using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing an array type.</summary>
    public class ArrayTypeSymbol : Symbol
    {
        internal ArrayTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
