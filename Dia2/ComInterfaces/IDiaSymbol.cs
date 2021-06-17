using Dia2Lib;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("cb787b2f-bd6c-4635-ba52-933126bd2dcd")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaSymbol
    {
        uint symIndexId { get; }
        SymbolTag symTag { [return: MarshalAs(UnmanagedType.U4)] get; }
        string name { get; }
        IDiaSymbol? lexicalParent { get; }
        IDiaSymbol? classParent { get; }
        IDiaSymbol? type { get; }
        DataKind dataKind { [return: MarshalAs(UnmanagedType.U4)] get; }
        LocationType locationType { [return: MarshalAs(UnmanagedType.U4)] get; }
        uint addressSection { get; }
        uint addressOffset { get; }
        uint relativeVirtualAddress { get; }
        ulong virtualAddress { get; }
        uint registerId { get; }
        int offset { get; }
        ulong length { get; }
        uint slot { get; }
        bool volatileType { get; }
        bool constType { get; }
        bool unalignedType { get; }
        MemberAccessLevel access { [return: MarshalAs(UnmanagedType.U4)] get; }
        string libraryName { get; }
        CpuType platform { [return: MarshalAs(UnmanagedType.U4)] get; }
        SourceCodeLanguage language { [return: MarshalAs(UnmanagedType.U4)] get; }
        bool editAndContinueEnabled { get; }
        uint frontEndMajor { get; }
        uint frontEndMinor { get; }
        uint frontEndBuild { get; }
        uint backEndMajor { get; }
        uint backEndMinor { get; }
        uint backEndBuild { get; }
        string sourceFileName { get; }
        string unused { get; }
        ThunkOrdinal thunkOrdinal { [return: MarshalAs(UnmanagedType.U4)] get; }
        int thisAdjust { get; }
        uint virtualBaseOffset { get; }
        bool @virtual { get; }
        bool intro { get; }
        bool pure { get; }
        FunctionCallingConvention callingConvention { [return: MarshalAs(UnmanagedType.U4)] get; }
        object value { get; }
        BasicType baseType { [return: MarshalAs(UnmanagedType.U4)] get; }
        uint token { get; }
        uint timeStamp { get; }
        Guid guid { get; }
        string symbolsFileName { get; }
        bool reference { get; }
        uint count { get; }
        uint bitPosition { get; }
        IDiaSymbol? arrayIndexType { get; }
        bool packed { get; }
        bool constructor { get; }
        bool overloadedOperator { get; }
        bool nested { get; }
        bool hasNestedTypes { get; }
        bool hasAssignmentOperator { get; }
        bool hasCastOperator { get; }
        bool scoped { get; }
        bool virtualBaseClass { get; }
        bool indirectVirtualBaseClass { get; }
        int virtualBasePointerOffset { get; }
        IDiaSymbol? virtualTableShape { get; }
        uint lexicalParentId { get; }
        uint classParentId { get; }
        uint typeId { get; }
        uint arrayIndexTypeId { get; }
        uint virtualTableShapeId { get; }
        bool code { get; }
        bool function { get; }
        bool managed { get; }
        bool msil { get; }
        uint virtualBaseDispIndex { get; }
        string undecoratedName { get; }
        uint age { get; }
        uint signature { get; }
        bool compilerGenerated { get; }
        bool addressTaken { get; }
        uint rank { get; }
        IDiaSymbol? lowerBound { get; }
        IDiaSymbol? upperBound { get; }
        uint lowerBoundId { get; }
        uint upperBoundId { get; }
        void getDataBytes(uint cbData, out uint pcbData, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[]? pData);
        IDiaEnumSymbols findChildren(SymbolTag symtag, string? name, NameSearchOptions compareFlags);
        IDiaEnumSymbols findChildrenEx(SymbolTag symtag, string? name, NameSearchOptions compareFlags);
        IDiaEnumSymbols findChildrenExByAddr(SymbolTag symtag, string? name, NameSearchOptions compareFlags, uint isect, uint offset);
        IDiaEnumSymbols findChildrenExByVA(SymbolTag symtag, string? name, NameSearchOptions compareFlags, ulong va);
        IDiaEnumSymbols findChildrenExByRVA(SymbolTag symtag, string? name, NameSearchOptions compareFlags, uint rva);
        uint targetSection { get; }
        uint targetOffset { get; }
        uint targetRelativeVirtualAddress { get; }
        ulong targetVirtualAddress { get; }
        ImageFileMachine machineType { [return: MarshalAs(UnmanagedType.U4)] get; }
        uint oemId { get; }
        uint oemSymbolId { get; }
        void getTypes(uint cTypes, out uint pcTypes, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDiaSymbol[]? pTypes);
        void getTypeIds(uint cTypeIds, out uint pcTypeIds, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[]? pdwTypeIds);
        IDiaSymbol? objectPointerType { get; }
        UserDefinedTypeKind udtKind { [return: MarshalAs(UnmanagedType.U4)] get; }
        string getUndecoratedNameEx(UndecorateOptions undecorateOptions);
        bool noReturn { get; }
        bool customCallingConvention { get; }
        bool noInline { get; }
        bool optimizedCodeDebugInfo { get; }
        bool notReached { get; }
        bool interruptReturn { get; }
        bool farReturn { get; }
        bool isStatic { get; }
        bool hasDebugInfo { get; }
        bool isLTCG { get; }
        bool isDataAligned { get; }
        bool hasSecurityChecks { get; }
        string compilerName { get; }
        bool hasAlloca { get; }
        bool hasSetJump { get; }
        bool hasLongJump { get; }
        bool hasInlAsm { get; }
        bool hasEH { get; }
        bool hasSEH { get; }
        bool hasEHa { get; }
        bool isNaked { get; }
        bool isAggregated { get; }
        bool isSplitted { get; }
        IDiaSymbol? container { get; }
        bool inlSpec { get; }
        bool noStackOrdering { get; }
        IDiaSymbol? virtualBaseTableType { get; }
        bool hasManagedCode { get; }
        bool isHotpatchable { get; }
        bool isCVTCIL { get; }
        bool isMSILNetmodule { get; }
        bool isCTypes { get; }
        bool isStripped { get; }
        uint frontEndQFE { get; }
        uint backEndQFE { get; }
        bool wasInlined { get; }
        bool strictGSCheck { get; }
        bool isCxxReturnUDT { get; }
        bool isConstructorVirtualBase { get; }
        bool RValueReference { get; }
        IDiaSymbol? unmodifiedType { get; }
        bool framePointerPresent { get; }
        bool isSafeBuffers { get; }
        bool intrinsic { get; }
        bool @sealed { get; }
        bool hfaFloat { get; }
        bool hfaDouble { get; }
        uint liveRangeStartAddressSection { get; }
        uint liveRangeStartAddressOffset { get; }
        uint liveRangeStartRelativeVirtualAddress { get; }
        uint countLiveRanges { get; }
        ulong liveRangeLength { get; }
        uint offsetInUdt { get; }
        uint paramBasePointerRegisterId { get; }
        uint localBasePointerRegisterId { get; }
        bool isLocationFlowControlDependent { get; }
        uint stride { get; }
        uint numberOfRows { get; }
        uint numberOfColumns { get; }
        bool isMatrixRowMajor { get; }
        void getNumericProperties(uint cnt, out uint pCnt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ushort[]? pProperties);
        void getModifierValues(uint cnt, out uint pCnt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ushort[]? pModifiers);
        bool isReturnValue { get; }
        bool isOptimizedAway { get; }
        uint builtInKind { get; }
        uint registerType { get; }
        uint baseDataSlot { get; }
        uint baseDataOffset { get; }
        uint textureSlot { get; }
        uint samplerSlot { get; }
        uint uavSlot { get; }
        uint sizeInUdt { get; }
        uint memorySpaceKind { get; }
        uint unmodifiedTypeId { get; }
        uint subTypeId { get; }
        IDiaSymbol? subType { get; }
        uint numberOfModifiers { get; }
        uint numberOfRegisterIndices { get; }
        bool isHLSLData { get; }
        bool isPointerToDataMember { get; }
        bool isPointerToMemberFunction { get; }
        bool isSingleInheritance { get; }
        bool isMultipleInheritance { get; }
        bool isVirtualInheritance { get; }
        bool restrictedType { get; }
        bool isPointerBasedOnSymbolValue { get; }
        IDiaSymbol? baseSymbol { get; }
        uint baseSymbolId { get; }
        string objectFileName { get; }
        bool isAcceleratorGroupSharedLocal { get; }
        bool isAcceleratorPointerTagLiveRange { get; }
        bool isAcceleratorStubFunction { get; }
        uint numberOfAcceleratorPointerTags { get; }
        bool isSdl { get; }
        bool isWinRTPointer { get; }
        bool isRefUdt { get; }
        bool isValueUdt { get; }
        bool isInterfaceUdt { get; }
        IDiaEnumSymbols findInlineFramesByAddr(uint isect, uint offset);
        IDiaEnumSymbols findInlineFramesByRVA(uint rva);
        IDiaEnumSymbols findInlineFramesByVA(ulong va);
        IDiaEnumLineNumbers findInlineeLines();
        IDiaEnumLineNumbers findInlineeLinesByAddr(uint isect, uint offset, uint length);
        IDiaEnumLineNumbers findInlineeLinesByRVA(uint rva, uint length);
        IDiaEnumLineNumbers findInlineeLinesByVA(ulong va, uint length);
        IDiaEnumSymbols findSymbolsForAcceleratorPointerTag(uint tagValue);
        IDiaEnumSymbols findSymbolsByRVAForAcceleratorPointerTag(uint tagValue, uint rva);
        void getAcceleratorPointerTags(uint cnt, out uint pCnt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[]? pPointerTags);
        IDiaLineNumber getSrcLineOnTypeDefn();
        bool isPGO { get; }
        bool hasValidPGOCounts { get; }
        bool isOptimizedForSpeed { get; }
        uint PGOEntryCount { get; }
        uint PGOEdgeCount { get; }
        ulong PGODynamicInstructionCount { get; }
        uint staticSize { get; }
        uint finalLiveStaticSize { get; }
        string phaseName { get; }
        bool hasControlFlowCheck { get; }
        bool constantExport { get; }
        bool dataExport { get; }
        bool privateExport { get; }
        bool noNameExport { get; }
        bool exportHasExplicitlyAssignedOrdinal { get; }
        bool exportIsForwarder { get; }
        uint ordinal { get; }
        uint frameSize { get; }
        uint exceptionHandlerAddressSection { get; }
        uint exceptionHandlerAddressOffset { get; }
        uint exceptionHandlerRelativeVirtualAddress { get; }
        ulong exceptionHandlerVirtualAddress { get; }
        IDiaInputAssemblyFile findInputAssemblyFile();
        uint characteristics { get; }
        IDiaSymbol? coffGroup { get; }
        uint bindID { get; }
        uint bindSpace { get; }
        uint bindSlot { get; }
    }
}
