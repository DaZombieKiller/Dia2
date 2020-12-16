using Dia2.ComInterfaces;

namespace Dia2
{
    public class HlslTypeSymbol : Symbol
    {
        internal HlslTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
