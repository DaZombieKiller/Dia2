using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing an inline site.</summary>
    public class InlineSiteSymbol : Symbol
    {
        internal InlineSiteSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
