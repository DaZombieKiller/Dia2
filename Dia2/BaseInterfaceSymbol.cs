using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a base interface.</summary>
    public class BaseInterfaceSymbol : Symbol
    {
        internal BaseInterfaceSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
