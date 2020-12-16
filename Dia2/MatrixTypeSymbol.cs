using Dia2.ComInterfaces;

namespace Dia2
{
    public class MatrixTypeSymbol : Symbol
    {
        internal MatrixTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
