using Dia2.ComInterfaces;

namespace Dia2
{
    public class AnnotationSymbol : Symbol
    {
        internal AnnotationSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
