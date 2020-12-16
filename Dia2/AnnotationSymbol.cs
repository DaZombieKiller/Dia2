using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A code annotation. Children of this symbol are constant data strings (<see cref="DataSymbol"/>, <see cref="LocationType.IsConstant"/>, <see cref="DataKind.IsConstant"/>). Most clients ignore this symbol.</summary>
    public class AnnotationSymbol : Symbol
    {
        internal AnnotationSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
