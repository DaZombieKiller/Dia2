using Dia2Lib;

namespace Dia2
{
    /// <summary>Specifies the type of symbol.</summary>
    /// <remarks>
    /// <para>All symbols within a debug file have an identifying tag that specifies the symbol's type.</para>
    /// <para>The values in this enumeration are returned by <see cref="Symbol.SymbolTag"/>.</para>
    /// <para>The values in this enumeration are passed to the following methods to limit the scope of the search to a specific symbol type:</para>
    /// <list type="bullet">
    /// <item><see cref="IDiaSession.findSymbolByAddr"/></item>
    /// <item><see cref="IDiaSession.findSymbolByRVA"/></item>
    /// <item><see cref="IDiaSession.findSymbolByRVAEx"/></item>
    /// <item><see cref="IDiaSession.findSymbolByToken"/></item>
    /// <item><see cref="IDiaSession.findSymbolByVA"/></item>
    /// <item><see cref="IDiaSession.findSymbolByVAEx"/></item>
    /// <item><see cref="IDiaSession.findChildren"/></item>
    /// <item><see cref="Symbol.FindChildren"/></item>
    /// </list>
    /// </remarks>
    public enum SymbolTag
    {
        /// <summary>Indicates that the symbol has no type.</summary>
        Null = SymTagEnum.SymTagNull,

        /// <summary>Indicates that the symbol is an .exe file. There is only one <see cref="Exe"/> symbol per symbol store. It serves as the global scope and does not have a lexical parent.</summary>
        Exe = SymTagEnum.SymTagExe,

        /// <summary>Indicates the compiland symbol for each compiland component of the symbol store. For native applications, <see cref="Compiland"/> symbols correspond to the object files linked into the image. For some kinds of Microsoft Intermediate Language (MSIL) images, there is one compiland per class.</summary>
        Compiland = SymTagEnum.SymTagCompiland,

        /// <summary>Indicates that the symbol contains extended attributes of the compiland. Retrieving these properties may require loading compiland symbols.</summary>
        CompilandDetails = SymTagEnum.SymTagCompilandDetails,

        /// <summary>Indicates that the symbol is an environment string defined for the compiland.</summary>
        CompilandEnv = SymTagEnum.SymTagCompilandEnv,

        /// <summary>Indicates that the symbol is a function.</summary>
        Function = SymTagEnum.SymTagFunction,

        /// <summary>Indicates that the symbol is a nested block.</summary>
        Block = SymTagEnum.SymTagBlock,

        /// <summary>Indicates that the symbol is data.</summary>
        Data = SymTagEnum.SymTagData,

        /// <summary>Indicates that the symbol is for a code annotation. Children of this symbol are constant data strings (<see cref="Data"/>, <see cref="LocationType.IsConstant"/>, <see cref="DataKind.IsConstant"/>). Most clients ignore this symbol.</summary>
        Annotation = SymTagEnum.SymTagAnnotation,

        /// <summary>Indicates that the symbol is a label.</summary>
        Label = SymTagEnum.SymTagLabel,

        /// <summary>Indicates that the symbol is a public symbol. For native applications, this symbol is the COFF external symbol encountered while linking the image.</summary>
        PublicSymbol = SymTagEnum.SymTagPublicSymbol,

        /// <summary>Indicates that the symbol is a user-defined type (structure, class, or union).</summary>
        UDT = SymTagEnum.SymTagUDT,

        /// <summary>Indicates that the symbol is an enumeration.</summary>
        Enum = SymTagEnum.SymTagEnum,

        /// <summary>Indicates that the symbol is a function signature type.</summary>
        FunctionType = SymTagEnum.SymTagFunctionType,

        /// <summary>Indicates that the symbol is a pointer type.</summary>
        PointerType = SymTagEnum.SymTagPointerType,

        /// <summary>Indicates that the symbol is an array type.</summary>
        ArrayType = SymTagEnum.SymTagArrayType,

        /// <summary>Indicates that the symbol is a base type.</summary>
        BaseType = SymTagEnum.SymTagBaseType,

        /// <summary>Indicates that the symbol is a <see langword="typedef"/>, that is, an alias for another type.</summary>
        Typedef = SymTagEnum.SymTagTypedef,

        /// <summary>Indicates that the symbol is a base class of a user-defined type.</summary>
        BaseClass = SymTagEnum.SymTagBaseClass,

        /// <summary>Indicates that the symbol is a friend of a user-defined type.</summary>
        Friend = SymTagEnum.SymTagFriend,

        /// <summary>Indicates that the symbol is a function argument.</summary>
        FunctionArgType = SymTagEnum.SymTagFunctionArgType,

        /// <summary>Indicates that the symbol is the end location of the function's prologue code.</summary>
        FuncDebugStart = SymTagEnum.SymTagFuncDebugStart,

        /// <summary>Indicates that the symbol is the beginning location of the function's epilogue code.</summary>
        FuncDebugEnd = SymTagEnum.SymTagFuncDebugEnd,

        /// <summary>Indicates that the symbol is a namespace name, active in the current scope.</summary>
        UsingNamespace = SymTagEnum.SymTagUsingNamespace,

        /// <summary>Indicates that the symbol is a virtual table description.</summary>
        VTableShape = SymTagEnum.SymTagVTableShape,

        /// <summary>Indicates that the symbol is a virtual table pointer.</summary>
        VTable = SymTagEnum.SymTagVTable,

        /// <summary>Indicates that the symbol is a custom symbol and is not interpreted by DIA.</summary>
        Custom = SymTagEnum.SymTagCustom,

        /// <summary>Indicates that the symbol is a thunk used for sharing data between 16 and 32 bit code.</summary>
        Thunk = SymTagEnum.SymTagThunk,

        /// <summary>Indicates that the symbol is a custom compiler symbol.</summary>
        CustomType = SymTagEnum.SymTagCustomType,

        /// <summary>Indicates that the symbol is in metadata.</summary>
        ManagedType = SymTagEnum.SymTagManagedType,

        /// <summary>Indicates that the symbol is a FORTRAN multi-dimensional array.</summary>
        Dimension = SymTagEnum.SymTagDimension,

        /// <summary>Indicates that the symbol represents the call site.</summary>
        CallSite = SymTagEnum.SymTagCallSite,

        /// <summary>Indicates that the symbol represents the inline site.</summary>
        InlineSite = SymTagEnum.SymTagInlineSite,

        /// <summary>Indicates that the symbol is a base interface.</summary>
        BaseInterface = SymTagEnum.SymTagBaseInterface,

        /// <summary>Indicates that the symbol is a vector type.</summary>
        VectorType = SymTagEnum.SymTagVectorType,

        /// <summary>Indicates that the symbol is a matrix type.</summary>
        MatrixType = SymTagEnum.SymTagMatrixType,

        /// <summary>Indicates that the symbol is a High Level Shader Language type.</summary>
        HLSLType = SymTagEnum.SymTagHLSLType
    }
}
