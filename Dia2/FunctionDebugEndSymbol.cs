using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing the beginning location of the function's epilogue code.</summary>
    public class FunctionDebugEndSymbol : Symbol
    {
        internal FunctionDebugEndSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
