namespace Dia2
{
    /// <summary>Specifies the source code language of the application or linked module.</summary>
    /// <remarks>The values in this enumeration are returned by <see cref="Symbol.Language"/>.</remarks>
    public enum SourceCodeLanguage
    {
        /// <summary>Application language is C.</summary>
        C,

        /// <summary>Application language is C++.</summary>
        Cxx,

        /// <summary>Application language is FORTRAN.</summary>
        Fortran,

        /// <summary>Application language is Microsoft Macro Assembler.</summary>
        Masm,

        /// <summary>Application language is Pascal.</summary>
        Pascal,

        /// <summary>Application language is BASIC.</summary>
        Basic,

        /// <summary>Application language is COBOL.</summary>
        Cobol,

        /// <summary>Application is a linker-generated module.</summary>
        Link,

        /// <summary>Application is a resource module converted with CVTRES tool.</summary>
        CvtRes,

        /// <summary>Application is a POGO optimized module generated with CVTPGD tool.</summary>
        CvtPgd,

        /// <summary>Application language is C#.</summary>
        CSharp,

        /// <summary>Application language is Visual Basic.</summary>
        VB,

        /// <summary>Application language is intermediate language assembly (that is, Common Language Runtime (CLR) assembly).</summary>
        ILAsm,

        /// <summary>Application language is Java.</summary>
        Java,

        /// <summary>Application language is Jscript.</summary>
        JScript,

        /// <summary>Application language is an unknown Microsoft Intermediate Language (MSIL), possibly a result of using the /LTCG (Link-time Code Generation) switch.</summary>
        Msil,

        /// <summary>Application language is High Level Shader Language.</summary>
        Hlsl
    }
}
