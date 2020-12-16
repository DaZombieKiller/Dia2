using Dia2.ComInterfaces;

namespace Dia2
{
    public class PublicSymbol : Symbol
    {
        /// <summary>Specifies whether the public symbol refers to a function.</summary>
        public bool IsFunction => symbol.function;

        internal PublicSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
