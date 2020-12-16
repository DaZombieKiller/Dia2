using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A custom symbol that is not interpreted by DIA.</summary>
    public class CustomSymbol : Symbol
    {
        internal CustomSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
