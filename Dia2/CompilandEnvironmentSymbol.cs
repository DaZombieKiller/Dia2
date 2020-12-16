using Dia2.ComInterfaces;

namespace Dia2
{
    public class CompilandEnvironmentSymbol : Symbol
    {
        internal CompilandEnvironmentSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
