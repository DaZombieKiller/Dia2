using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a managed type.</summary>
    public class ManagedTypeSymbol : Symbol
    {
        internal ManagedTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
