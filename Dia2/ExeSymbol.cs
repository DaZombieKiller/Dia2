using Dia2.ComInterfaces;

namespace Dia2
{
    public class ExeSymbol : Symbol
    {
        /// <summary>Indicates whether the symbol file contains C types.</summary>
        /// <remarks>This property is available from the <see cref="SymbolTag.Exe"/> symbol type.</remarks>
        public bool IsCTypes => symbol.isCTypes;

        /// <summary>Indicates whether private symbols were stripped from the symbol file.</summary>
        /// <remarks>This property is available from the <see cref="SymbolTag.Exe"/> symbol type.</remarks>
        public bool IsStripped => symbol.isStripped;

        /// <summary>The name of the file from which the symbols were loaded.</summary>
        /// <remarks>This property is valid only for symbols with a <see cref="SymbolTag"/> value of <see cref="SymbolTag.Exe"/> that also have global scope.</remarks>
        public string SymbolsFileName => symbol.symbolsFileName;

        internal ExeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
