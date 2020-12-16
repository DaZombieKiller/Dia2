using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing the end location of the function's prologue code.</summary>
    public class FunctionDebugStartSymbol : Symbol
    {
        internal FunctionDebugStartSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
