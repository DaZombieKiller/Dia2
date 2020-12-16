using Dia2.ComInterfaces;

namespace Dia2
{
    public class CompilandSymbol : Symbol
    {
        internal CompilandSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
