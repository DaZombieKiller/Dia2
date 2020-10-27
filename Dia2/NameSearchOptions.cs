using System;
using Dia2Lib;

namespace Dia2
{
    /// <summary>Specifies the search options for symbol and file names.</summary>
    /// <remarks>
    /// The values from this enumeration are passed to the following methods:
    /// <list type="bullet">
    /// <item><see cref="IDiaSession.findChildren"/></item>
    /// <item><see cref="IDiaSession.findFile"/></item>
    /// <item><see cref="IDiaSymbol.findChildren"/></item>
    /// </list>
    /// </remarks>
    [Flags]
    public enum NameSearchOptions : uint
    {
        /// <summary>No options are specified.</summary>
        None,

        /// <summary>Applies a case-sensitive name match.</summary>
        CaseSensitive = 1 << 0,

        /// <summary>Applies a case-insensitive name match.</summary>
        CaseInsensitive = 1 << 1,

        /// <summary>Treats names as paths and applies a filename.ext name match.</summary>
        FileNameExtension = 1 << 2,

        /// <summary>Applies a case-sensitive name match using asterisks (*) and question marks (?) as wildcards. (Other common regular expression characters are not supported.)</summary>
        RegularExpression = 1 << 3,

        /// <summary>Applies only to symbols that have both undecorated and decorated names.</summary>
        UndecoratedName = 1 << 4,
    }
}
