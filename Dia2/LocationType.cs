namespace Dia2
{
    /// <summary>Indicates the kind of location information contained in a symbol.</summary>
    /// <remarks>
    /// <para>The properties available to the <see cref="Symbol"/> depend on the symbol's location within the image file.</para>
    /// <para>The values in this enumeration are returned by <see cref="Symbol.LocationType"/>.</para>
    /// </remarks>
    public enum LocationType
    {
        /// <summary>Location information is unavailable.</summary>
        IsNull,

        /// <summary>Location is static.</summary>
        IsStatic,

        /// <summary>Location is in thread local storage.</summary>
        IsTLS,

        /// <summary>Location is register-relative.</summary>
        IsRegRel,

        /// <summary>Location is <see langword="this"/>-relative.</summary>
        IsThisRel,

        /// <summary>Location is in a register.</summary>
        IsEnregistered,

        /// <summary>Location is in a bit field.</summary>
        IsBitField,

        /// <summary>Location is a Microsoft Intermediate Language (MSIL) slot.</summary>
        IsSlot,

        /// <summary>Location is MSIL-relative.</summary>
        IsIlRel,

        /// <summary>Location is in metadata.</summary>
        InMetaData,

        /// <summary>Location is in a constant value.</summary>
        IsConstant
    }
}
