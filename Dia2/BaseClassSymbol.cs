using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a base class of a user-defined type.</summary>
    public class BaseClassSymbol : Symbol
    {
        internal BaseClassSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
