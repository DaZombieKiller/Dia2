using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a label.</summary>
    public class LabelSymbol : Symbol
    {
        internal LabelSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
