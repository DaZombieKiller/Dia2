using Dia2.ComInterfaces;

namespace Dia2
{
    /// <summary>A symbol representing a user-defined type (<see langword="struct"/>, <see langword="class"/>, or <see langword="union"/>).</summary>
    public class UserDefinedTypeSymbol : Symbol
    {
        /// <summary>Specifies whether the user-defined data type has a constructor or destructor.</summary>
        public bool HasConstructorOrDestructor => symbol.constructor;

        /// <summary>Specifies whether the user-defined data type is constant.</summary>
        public bool IsConstantType => symbol.constType;

        /// <summary>Specifies whether the user-defined data type has any assignment operators defined.</summary>
        public bool HasAssignmentOperator => symbol.hasAssignmentOperator;

        /// <summary>Specifies whether the user-defined data type has any cast operators defined.</summary>
        public bool HasCastOperator => symbol.hasCastOperator;

        /// <summary>Specifies whether the user-defined data type has nested type definitions.</summary>
        public bool HasNestedTypes => symbol.hasNestedTypes;

        /// <summary>Specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type float.</summary>
        public bool ContainsHfaFloat => symbol.hfaFloat;

        /// <summary>Specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type double.</summary>
        public bool ContainsHfaDouble => symbol.hfaDouble;

        /// <summary>Specifies whether the user-defined data type is an indirect virtual base class.</summary>
        public bool IsIndirectVirtualBaseClass => symbol.indirectVirtualBaseClass;

        /// <summary>Specifies whether the user-defined type (UDT) has been aligned to some specific memory boundary.</summary>
        /// <remarks>
        /// This property is generally set when the executable is compiled with nondefault data alignment.
        /// For example, the Microsoft C++ compiler can change the data alignment with the command-line option, /Zp#, where # is a byte value.
        /// </remarks>
        public bool IsDataAligned => symbol.isDataAligned;

        /// <summary>Specifies whether the user-defined data type is nested.</summary>
        public bool IsNested => symbol.nested;

        /// <summary>Specifies whether the user-defined data type has overloaded operators.</summary>
        public bool HasOverloadedOperators => symbol.overloadedOperator;

        /// <summary>Specifies whether the user-defined data type (UDT) is packed.</summary>
        /// <remarks>Packed means all the members of the UDT are positioned as close together as possible, with no intervening padding to align to memory boundaries.</remarks>
        public bool IsPacked => symbol.packed;

        /// <summary>Specifies whether the user-defined data type appears in a non-global lexical scope.</summary>
        public bool IsScoped => symbol.scoped;

        /// <summary>The variety of a user-defined type (UDT).</summary>
        public UdtKind Kind => symbol.udtKind;

        /// <summary>Specifies whether the user-defined data type is unaligned.</summary>
        public bool IsUnaligned => symbol.unalignedType;

        /// <summary>Specifies whether the user-defined data type is a virtual base class.</summary>
        public bool IsVirtualBaseClass => symbol.virtualBaseClass;

        /// <summary>The symbol of the type of the virtual table for a user-defined type.</summary>
        public VTableShapeSymbol? VirtualTableShape => (VTableShapeSymbol?)pdb.GetOrCreateSymbol(symbol.virtualTableShape);

        /// <summary>The virtual table shape symbol identifier of the symbol.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint VirtualTableShapeID => symbol.virtualTableShapeId;

        /// <summary>Specifies whether the user-defined data type (UDT) is volatile.</summary>
        /// <remarks>In C++, a UDT can be marked with the <see langword="volatile"/> keyword, indicating that its contents cannot be assumed to exist from one access to the next.</remarks>
        public bool IsVolatile => symbol.volatileType;

        internal UserDefinedTypeSymbol(Pdb pdb, IDiaSymbol symbol)
            : base(pdb, symbol)
        {
        }
    }
}
