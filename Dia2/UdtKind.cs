namespace Dia2
{
    /// <summary>Describes the variety of user-defined types (UDTs).</summary>
    /// <remarks>The values in this enumeration are returned by <see cref="Symbol.UdtKind"/>.</remarks>
    public enum UdtKind
    {
        /// <summary>UDT is a structure.</summary>
        Struct,

        /// <summary>UDT is a class.</summary>
        Class,

        /// <summary>UDT is a union.</summary>
        Union,

        /// <summary>UDT is an interface.</summary>
        Interface
    }
}
