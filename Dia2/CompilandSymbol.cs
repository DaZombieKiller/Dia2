using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>Correspond to an object file linked into the image. For some kinds of Microsoft Intermediate Language (MSIL) images, there is one compiland per class.</summary>
    public class CompilandSymbol : Symbol
    {
        /// <summary>The name of the compiler used to generate the Compiland.</summary>
        public string CompilerName => symbol.compilerName;

        /// <summary>Specifies if the Compiland contains debugging information.</summary>
        public bool HasDebugInfo => symbol.hasDebugInfo;

        /// <summary>Specifies whether the Compiland has been linked with the linker switch /LTCG (Link-time Code Generation), which aids in whole program optimization. This switch applies only to managed code.</summary>
        public bool LinkTimeCodeGeneration => symbol.isLTCG;

        /// <summary>The platform type for which the compiland was compiled.</summary>
        public CpuType Platform => symbol.platform;

        /// <summary>The file name of the compiland source file.</summary>
        public string SourceFileName => symbol.sourceFileName;

        internal CompilandSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
