using Dia2.ComInterfaces;

namespace Dia2
{
    public class FunctionDebugStartSymbol : Symbol
    {
        internal FunctionDebugStartSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
