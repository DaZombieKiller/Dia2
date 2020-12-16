using Dia2.ComInterfaces;

namespace Dia2
{
    public class FunctionArgumentTypeSymbol : Symbol
    {
        internal FunctionArgumentTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
