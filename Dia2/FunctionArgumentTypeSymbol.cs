using Dia2.ComInterfaces;

namespace Dia2
{
    // TODO: Does this represent the actual argument, or just its type?
    /// <summary>A symbol representing a function argument.</summary>
    public class FunctionArgumentTypeSymbol : Symbol
    {
        internal FunctionArgumentTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
