using Dia2.ComInterfaces;

namespace Dia2
{
    public class FunctionDebugEndSymbol : Symbol
    {
        internal FunctionDebugEndSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
