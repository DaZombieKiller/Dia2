using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing an enumeration.</summary>
    public class EnumSymbol : Symbol
    {
        internal EnumSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
