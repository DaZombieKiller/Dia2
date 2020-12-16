using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a <see langword="typedef"/>, that is, an alias for another type.</summary>
    public class TypedefSymbol : Symbol
    {
        internal TypedefSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
