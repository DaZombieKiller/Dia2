namespace Dia2
{
    /// <summary>Indicates the particular scope of a data value.</summary>
    /// <remarks>The values in this enumeration are returned by <see cref="Symbol.DataKind"/>.</remarks>
    public enum DataKind
    {
        /// <summary>Data symbol cannot be determined.</summary>
        IsUnknown,

        /// <summary>Data item is a local variable.</summary>
        IsLocal,

        /// <summary>Data item is a static local variable.</summary>
        IsStaticLocal,

        /// <summary>Data item is a formal parameter.</summary>
        IsParam,

        /// <summary>Data item is an object pointer (<see langword="this"/>).</summary>
        IsObjectPtr,

        /// <summary>Data item is a file-scoped variable.</summary>
        IsFileStatic,

        /// <summary>Data item is a global variable.</summary>
        IsGlobal,

        /// <summary>Data item is an object member variable.</summary>
        IsMember,

        /// <summary>Data item is a class static variable.</summary>
        IsStaticMember,

        /// <summary>Data item is a constant value.</summary>
        IsConstant
    }
}
