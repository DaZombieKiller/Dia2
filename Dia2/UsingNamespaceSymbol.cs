using Dia2.ComInterfaces;

namespace Dia2
{
    public class UsingNamespaceSymbol : Symbol
    {
        internal UsingNamespaceSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
