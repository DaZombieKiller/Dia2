using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a base type.</summary>
    public class BaseTypeSymbol : Symbol
    {
        internal BaseTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
