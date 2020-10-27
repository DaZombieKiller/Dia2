namespace Dia2
{
    /// <summary>Specifies the scope of visibility (access level) of member functions and variables.</summary>
    /// <remarks>The <see langword="friend"/> access specifier is not included here because it is typically used by non-member functions that have access to both private and protected elements of the class. Use <see cref="Symbol.SymbolTag"/> to find symbols with <see cref="SymbolTag.Friend"/> access.</remarks>
    public enum MemberAccessLevel
    {
        /// <summary>Member has private access.</summary>
        Private = 1,

        /// <summary>Member has protected access.</summary>
        Protected = 2,

        /// <summary>Member has public access.</summary>
        Public = 3
    }
}
