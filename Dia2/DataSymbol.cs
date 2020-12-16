using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing data.</summary>
    public class DataSymbol : Symbol
    {
        internal DataSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
