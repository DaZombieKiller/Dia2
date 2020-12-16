using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a vector type.</summary>
    public class VectorTypeSymbol : Symbol
    {
        internal VectorTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
