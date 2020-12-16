using Dia2.ComInterfaces;

namespace Dia2
{
    public class CompilandDetailsSymbol : Symbol
    {
        /// <summary>Indicates whether the module contains managed code.</summary>
        /// <remarks>This property is available from the <see cref="SymbolTag.CompilandDetails"/> symbol type.</remarks>
        public bool HasManagedCode => symbol.hasManagedCode;

        /// <summary>Indicates whether the module was converted from a Common Intermediate Language (CIL) module to a native module.</summary>
        /// <remarks>This property is available from the <see cref="SymbolTag.CompilandDetails"/> symbol type.</remarks>
        public bool IsConvertedCil => symbol.isCVTCIL;

        /// <summary>Indicates whether the module was compiled with the /hotpatch (Create Hotpatchable Image) compiler switch.</summary>
        /// <remarks>This property is available from the <see cref="SymbolTag.CompilandDetails"/> symbol type.</remarks>
        public bool IsHotPatchable => symbol.isHotpatchable;

        /// <summary>Indicates whether the module is a .netmodule (a Microsoft Intermediate Language (MSIL) module that contains only metadata and no native symbols).</summary>
        /// <remarks>This property is available from the <see cref="SymbolTag.CompilandDetails"/> symbol type.</remarks>
        public bool IsMsilNetModule => symbol.isMSILNetmodule;

        internal CompilandDetailsSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
