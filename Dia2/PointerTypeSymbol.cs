using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a pointer type.</summary>
    public class PointerTypeSymbol : Symbol
    {
        internal PointerTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
