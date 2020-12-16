using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a matrix type.</summary>
    public class MatrixTypeSymbol : Symbol
    {
        internal MatrixTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
