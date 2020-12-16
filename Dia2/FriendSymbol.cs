using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a friend of a user-defined type.</summary>
    public class FriendSymbol : Symbol
    {
        internal FriendSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
