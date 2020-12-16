using Dia2.ComInterfaces;

namespace Dia2
{
    public class FunctionSymbol : Symbol
    {
        /// <summary>Specifies whether the frame pointer is present.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public bool FramePointerPresent => symbol.framePointerPresent;

        /// <summary>Specifies whether the preprocesser directive for a safe buffer is used.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public bool IsSafeBuffers => symbol.isSafeBuffers;

        /// <summary>The ID of the register that holds a base pointer to local variables on the stack.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public uint LocalBasePointerRegisterID => symbol.localBasePointerRegisterId;

        /// <summary>The ID of the register that holds a base pointer to the parameters.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is <see cref="SymbolTag.Function"/>.</remarks>
        public uint ParamBasePointerRegisterID => symbol.paramBasePointerRegisterId;

        /// <summary>Specifies whether the function contains a far return.</summary>
        public bool HasFarReturn => symbol.farReturn;

        /// <summary>Specifies whether the function contains a call to <c>alloca</c> (which is used to allocate memory on the stack).</summary>
        public bool HasAlloca => symbol.hasAlloca;

        /// <summary>Specifies whether the function contains any unmanaged C++-style exception handling (for example, a try/catch block).</summary>
        public bool HasExceptionHandling => symbol.hasEH;

        /// <summary>Specifies whether the function contains asynchronous (structured) exception handling.</summary>
        public bool HasAsyncExceptionHandling => symbol.hasEHa;

        /// <summary>Specifies whether the function contains inline assembly.</summary>
        public bool HasInlineAssembly => symbol.hasInlAsm;

        /// <summary>Specifies whether the function contains a use of the <c>longjmp</c> command (paired with a <c>setjmp</c> command, these form the C-style method of exception handling).</summary>
        public bool HasLongJump => symbol.hasLongJump;

        /// <summary>Specifies whether the compiland or function has been compiled with buffer-overrun security checks (for example, the /GS (Buffer Security Check) compiler switch).</summary>
        public bool HasSecurityChecks => symbol.hasSecurityChecks;

        /// <summary>Specifies whether the function contains any Structured Exception Handling (C/C++) (for example, __try/__except blocks).</summary>
        public bool HasStructuredExceptionHandling => symbol.hasSEH;

        /// <summary>Specifies whether the function contains a use of the <c>setjmp</c> command (paired with the <c>longjmp</c> command, these form the C-style method of exception handling).</summary>
        public bool HasSetJump => symbol.hasSetJump;

        /// <summary>Indicates whether the function was marked as inline (using one of the inline, __inline, __forceinline attributes).</summary>
        public bool InlineSpecified => symbol.inlSpec;

        /// <summary>Specifies whether the function contains a return from interrupt instruction (for example, the X86 assembly code <c>iret</c>).</summary>
        public bool HasInterruptReturn => symbol.interruptReturn;

        /// <summary>Specifies whether the function has the <c>naked</c> attribute (that is, the function has no prolog or epilog code added by the compiler).</summary>
        public bool IsNaked => symbol.isNaked;

        /// <summary>Specifies whether the function has been marked as being not inline (using the <c>noinline</c> attribute).</summary>
        public bool NoInline => symbol.noInline;

        /// <summary>Specifies whether the function has been marked as never returning with the <c>noreturn</c> attribute.</summary>
        public bool DoesNotReturn => symbol.noReturn;

        /// <summary>Specifies whether the function or label is never reached.</summary>
        public bool IsNeverReached => symbol.notReached;

        /// <summary>Indicates whether the function contains debug information that is specific for optimized code.</summary>
        public bool HasOptimizedCodeDebugInfo => symbol.optimizedCodeDebugInfo;

        /// <summary>Specifies whether the function is pure virtual.</summary>
        public bool IsPureVirtual => symbol.pure;

        /// <summary>Specifies whether the function is virtual.</summary>
        public bool IsVirtual => symbol.@virtual;

        /// <summary>The offset in the virtual function table of a virtual function.</summary>
        public uint VirtualBaseOffset => symbol.virtualBaseOffset;

        internal FunctionSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
