using Dia2Lib;

namespace Dia2
{
    /// <summary>Specifies the type of memory to access.</summary>
    /// <remarks>The values in this enumeration are passed to the <see cref="IDiaStackWalkHelper.readMemory"/> method to limit access to different types of memory.</remarks>
    public enum MemoryType
    {
        /// <summary>Accesses any kind of memory.</summary>
        Any = MemoryTypeEnum.MemTypeAny,

        /// <summary>Accesses only code memory.</summary>
        Code = MemoryTypeEnum.MemTypeCode,

        /// <summary>Accesses data or stack memory.</summary>
        Data = MemoryTypeEnum.MemTypeData,

        /// <summary>Accesses only stack memory.</summary>
        Stack = MemoryTypeEnum.MemTypeStack,

        /// <summary></summary>
        CodeOnHeap = MemoryTypeEnum.MemTypeCodeOnHeap
    }
}
