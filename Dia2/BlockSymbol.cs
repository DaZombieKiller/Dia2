using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a nested block.</summary>
    public class BlockSymbol : Symbol
    {
        internal BlockSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
