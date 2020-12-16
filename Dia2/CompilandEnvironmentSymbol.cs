using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>An environment string defined for a compiland.</summary>
    public class CompilandEnvironmentSymbol : Symbol
    {
        internal CompilandEnvironmentSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
