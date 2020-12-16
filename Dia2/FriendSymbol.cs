using Dia2.ComInterfaces;

namespace Dia2
{
    public class FriendSymbol : Symbol
    {
        internal FriendSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
