using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A public symbol. For native applications, this symbol is the COFF external symbol encountered while linking the image.</summary>
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
