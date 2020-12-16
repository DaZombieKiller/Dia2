using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a namespace name, active in the current scope.</summary>
    public class UsingNamespaceSymbol : Symbol
    {
        internal UsingNamespaceSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
