using Dia2.ComInterfaces;

namespace Dia2
{
    public class BlockSymbol : Symbol
    {
        internal BlockSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
