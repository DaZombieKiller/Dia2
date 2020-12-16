using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a call site.</summary>
    public class CallSiteSymbol : Symbol
    {
        internal CallSiteSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
