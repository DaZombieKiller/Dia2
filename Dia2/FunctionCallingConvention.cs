namespace Dia2
{
    /// <summary>Specifies the calling convention for a function.</summary>
    /// <remarks>The values in this enumeration are returned by <see cref="Symbol.CallingConvention"/>.</remarks>
    public enum FunctionCallingConvention
    {
        /// <summary>Specifies a function-calling convention using a near right-to-left push. The calling function clears the stack.</summary>
        NearC = 0x00,

        /// <summary>Specifies a function-calling convention using a near left-to-right push with registers. The called function uses the sum of parameter bytes to clear the stack.</summary>
        NearFast = 0x04,

        /// <summary>Specifies a function-calling convention using a near standard call (right-to-left push).</summary>
        NearStd = 0x07,

        /// <summary>Specifies a function-calling convention using a near system call.</summary>
        NearSys = 0x09,

        /// <summary>Specifies a function-calling convention using <see langword="this"/> call (<see langword="this"/> pointer passed in register).</summary>
        ThisCall = 0x0b,

        /// <summary>Specifies a function-calling convention used by the Common Language Runtime (CLR) (also known as a managed code calling convention).</summary>
        ClrCall = 0x16
    }
}
