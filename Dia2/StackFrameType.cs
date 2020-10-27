using Dia2Lib;

namespace Dia2
{
    /// <summary>Specifies the stack frame type.</summary>
    /// <remarks>The values in this enumeration are returned by <see cref="IDiaStackFrame.type"/>.</remarks>
    public enum StackFrameType
    {
        /// <summary>Frame that does not have any debug info.</summary>
        Unknown = -1,

        /// <summary>Frame pointer omitted; FPO info available.</summary>
        FPO,

        /// <summary>Kernel Trap frame.</summary>
        Trap,

        /// <summary>Kernel Trap frame.</summary>
        TSS,

        /// <summary>Standard EBP stack frame.</summary>
        Standard,

        /// <summary>Frame pointer omitted; Frame data info available.</summary>
        FrameData
    }
}
