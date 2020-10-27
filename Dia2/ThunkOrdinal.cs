namespace Dia2
{
    /// <summary>Designates thunk types.</summary>
    /// <remarks>The values in this enumeration are returned by <see cref="Symbol.ThunkOrdinal"/>.</remarks>
    public enum ThunkOrdinal
    {
        /// <summary>Standard thunk.</summary>
        NoType,

        /// <summary>A <see langword="this"/> adjustor thunk.</summary>
        Adjustor,

        /// <summary>Virtual call thunk.</summary>
        VCall,

        /// <summary>P-code thunk.</summary>
        PCode,

        /// <summary>Delay load thunk.</summary>
        Load,

        /// <summary>Incremental trampoline thunk (a trampoline thunk is used to bounce calls from one memory space to another).</summary>
        TrampolineIncremental,

        /// <summary>Branch point trampoline thunk.</summary>
        TrampolineBranchIsland
    }
}
