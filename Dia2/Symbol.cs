using System;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dia2.ComInterfaces;

namespace Dia2
{
    public class Symbol : IEquatable<Symbol>
    {
        private protected readonly Pdb pdb;

        private protected readonly IDiaSymbol symbol;

        /// <summary>The access modifier of a class member.</summary>
        public MemberAccessLevel Access => symbol.access;

        /// <summary>The offset part of an address location.</summary>
        /// <remarks>
        /// <para>Use when <see cref="LocationType"/> is <see cref="LocationType.IsStatic"/>.</para>
        /// <para>
        /// For static members located in an external DLL, the offset returned by this method may be 0 as
        /// this method relies on obtaining the virtual address of the member. Virtual addresses are valid
        /// only if <see cref="Pdb.LoadAddress"/> is a nonzero value specifying the load address of the DLL.
        /// </para>
        /// <para>To get the section part of an address, use <see cref="AddressSection"/>.</para>
        /// </remarks>
        public uint AddressOffset => symbol.addressOffset;

        /// <summary>The section part of an address location.</summary>
        /// <remarks>
        /// <para>Use when <see cref="LocationType"/> is <see cref="LocationType.IsStatic"/>.</para>
        /// <para>
        /// For static members located in an external DLL, the section returned by this method may be 0 as
        /// this method relies on obtaining the virtual address of the member. Virtual addresses are valid
        /// only if <see cref="Pdb.LoadAddress"/> is a nonzero value specifying the load address of the DLL.
        /// </para>
        /// <para>To get the offset part of an address, use <see cref="AddressOffset"/>.</para>
        /// </remarks>
        public uint AddressSection => symbol.addressSection;

        /// <summary>Indicates whether another symbol references this symbol's address.</summary>
        public bool AddressTaken => symbol.addressTaken;

        /// <summary>The age value of a .pdb file.</summary>
        /// <remarks>
        /// The age does not necessarily correspond to any known time value; it is typically
        /// used to determine if a .pdb file is out of sync with a corresponding .exe file.
        /// </remarks>
        public uint Age => symbol.age;

        /// <summary>The symbol of the array index type of the symbol.</summary>
        /// <remarks>
        /// Some languages can specify the type used as an index to an array.
        /// The symbol returned from this method specifies that type.
        /// </remarks>
        public Symbol? ArrayIndexType => pdb.GetOrCreateSymbol(symbol.arrayIndexType);

        /// <summary>The array index type identifier of the symbol.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint ArrayIndexTypeID => symbol.arrayIndexTypeId;

        /// <summary>The back end build number of the compiler.</summary>
        /// <remarks>
        /// A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing
        /// the source code into an intermediate form, and a back end (code generator), which converts the intermediate
        /// form into assembly. It is not uncommon for the front end to have a different version than the back end.
        /// A front end or back end version number is composed of three parts: &lt;major&gt;.&lt;minor&gt;.&lt;build&gt;,
        /// where &lt;major&gt; is the major version number, &lt;minor&gt; is the minor version number, and &lt;build&gt;
        /// is the build number. For example, 13.10.3077.
        /// </remarks>
        public uint BackEndBuild => symbol.backEndBuild;

        /// <summary>The back end major version number of the compiler.</summary>
        /// <remarks>
        /// A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing
        /// the source code into an intermediate form, and a back end (code generator), which converts the intermediate
        /// form into assembly. It is not uncommon for the front end to have a different version than the back end.
        /// A front end or back end version number is composed of three parts: &lt;major&gt;.&lt;minor&gt;.&lt;build&gt;,
        /// where &lt;major&gt; is the major version number, &lt;minor&gt; is the minor version number, and &lt;build&gt;
        /// is the build number. For example, 13.10.3077.
        /// </remarks>
        public uint BackEndMajor => symbol.backEndMajor;

        /// <summary>The back end minor version number of the compiler.</summary>
        /// <remarks>
        /// A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing
        /// the source code into an intermediate form, and a back end (code generator), which converts the intermediate
        /// form into assembly. It is not uncommon for the front end to have a different version than the back end.
        /// A front end or back end version number is composed of three parts: &lt;major&gt;.&lt;minor&gt;.&lt;build&gt;,
        /// where &lt;major&gt; is the major version number, &lt;minor&gt; is the minor version number, and &lt;build&gt;
        /// is the build number. For example, 13.10.3077.
        /// </remarks>
        public uint BackEndMinor => symbol.backEndMinor;

        /// <summary>The base data offset.</summary>
        public uint BaseDataOffset => symbol.baseDataOffset;

        /// <summary>The base data slot.</summary>
        public uint BaseDataSlot => symbol.baseDataSlot;

        /// <summary>The symbol from which the pointer is based.</summary>
        public Symbol? BaseSymbol => pdb.GetOrCreateSymbol(symbol.baseSymbol);

        /// <summary>The symbol ID from which the pointer is based.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint BaseSymbolID => symbol.baseSymbolId;

        /// <summary>The base type for this symbol.</summary>
        /// <remarks>
        /// The basic type for a symbol can be determined by first getting the type of the symbol and then
        /// interrogating that returned type for the base type. Note that some symbols may not have a base
        /// type—for example, a structure name.
        /// </remarks>
        public BasicType BaseType => symbol.baseType;

        /// <summary>The bit position of <see cref="LocationType"/>. Used when <see cref="LocationType"/> is <see cref="LocationType.IsBitField"/>.</summary>
        public uint BitPosition => symbol.bitPosition;

        // TODO: Does this go on FunctionSymbol or FunctionTypeSymbol? Both?
        /// <summary>An indicator of a method's calling convention.</summary>
        public FunctionCallingConvention CallingConvention => symbol.callingConvention;

        /// <summary>The class parent of the symbol.</summary>
        public Symbol? ClassParent => pdb.GetOrCreateSymbol(symbol.classParent);

        /// <summary>The class parent identifier of the symbol.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint ClassParentID => symbol.classParentId;

        /// <summary>Specifies whether the symbol refers to a code address.</summary>
        public bool Code => symbol.code;

        /// <summary>Indicates whether the symbol was generated by the compiler.</summary>
        public bool CompilerGenerated => symbol.compilerGenerated;

        /// <summary>A symbol representing the parent/container of this symbol.</summary>
        public Symbol? Container => pdb.GetOrCreateSymbol(symbol.container);

        /// <summary>The number of items in a list or array.</summary>
        public uint Count => symbol.count;

        /// <summary>The number of valid address ranges associated with the local symbol.</summary>
        public uint CountLiveRanges => symbol.countLiveRanges;

        // TODO: Does this go on FunctionSymbol or FunctionTypeSymbol?
        /// <summary>Specifies whether the function has a custom calling convention.</summary>
        public bool CustomCallingConvention => symbol.customCallingConvention;

        /// <summary>The data bytes of an OEM symbol.</summary>
        public byte[] DataBytes
        {
            get
            {
                symbol.getDataBytes(0, out uint cbData, null);

                if (cbData == 0)
                    return Array.Empty<byte>();

                var data = new byte[cbData];
                symbol.getDataBytes(cbData, out _, data);
                return data;
            }
        }

        /// <summary>The variable classification of a data symbol.</summary>
        public DataKind DataKind => symbol.dataKind;

        /// <summary>Indicates whether the module was compiled with the /Z7, /Zi, /ZI (Debug Information Format) compiler switch.</summary>
        public bool EditAndContinueEnabled => symbol.editAndContinueEnabled;

        /// <summary>The front end build number of the compiler.</summary>
        /// <remarks>
        /// A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing
        /// the source code into an intermediate form, and a back end (code generator), which converts the intermediate
        /// form into assembly. It is not uncommon for the front end to have a different version than the back end.
        /// A front end or back end version number is composed of three parts: &lt;major&gt;.&lt;minor&gt;.&lt;build&gt;,
        /// where &lt;major&gt; is the major version number, &lt;minor&gt; is the minor version number, and &lt;build&gt;
        /// is the build number. For example, 13.10.3077.
        /// </remarks>
        public uint FrontEndBuild => symbol.frontEndBuild;

        /// <summary>The front end major version number of the compiler.</summary>
        /// <remarks>
        /// A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing
        /// the source code into an intermediate form, and a back end (code generator), which converts the intermediate
        /// form into assembly. It is not uncommon for the front end to have a different version than the back end.
        /// A front end or back end version number is composed of three parts: &lt;major&gt;.&lt;minor&gt;.&lt;build&gt;,
        /// where &lt;major&gt; is the major version number, &lt;minor&gt; is the minor version number, and &lt;build&gt;
        /// is the build number. For example, 13.10.3077.
        /// </remarks>
        public uint FrontEndMajor => symbol.frontEndMajor;

        /// <summary>The front end minor version number of the compiler.</summary>
        /// <remarks>
        /// A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing
        /// the source code into an intermediate form, and a back end (code generator), which converts the intermediate
        /// form into assembly. It is not uncommon for the front end to have a different version than the back end.
        /// A front end or back end version number is composed of three parts: &lt;major&gt;.&lt;minor&gt;.&lt;build&gt;,
        /// where &lt;major&gt; is the major version number, &lt;minor&gt; is the minor version number, and &lt;build&gt;
        /// is the build number. For example, 13.10.3077.
        /// </remarks>
        public uint FrontEndMinor => symbol.frontEndMinor;

        /// <summary>The symbol's globally unique identifier (GUID).</summary>
        public Guid Guid => symbol.guid;

        /// <summary>Specifies whether a class is an intrinsic type.</summary>
        public bool Intrinsic => symbol.intrinsic;

        /// <summary>Specifies whether the function is an introducing virtual function.</summary>
        public bool Intro => symbol.intro;

        /// <summary>Specifies whether the data symbol is part of an aggregate or collection of symbols; the compiler will treat aggregated symbols as separate entities, but they are really part of a single larger symbol.</summary>
        /// <remarks><see cref="IsSplitted"/> is <see langword="true"/> for the symbol that is the parent of the aggregated symbols.</remarks>
        public bool IsAggregated => symbol.isAggregated;

        /// <summary>Specifies whether this symbol represents High Level Shader Language (HLSL) data.</summary>
        public bool IsHlslData => symbol.isHLSLData;

        /// <summary>Specifies whether the matrix is row major.</summary>
        public bool IsMatrixRowMajor => symbol.isMatrixRowMajor;

        /// <summary>Specifies whether the <see langword="this"/> pointer points to a data member with multiple inheritance.</summary>
        public bool IsMultipleInheritance => symbol.isMultipleInheritance;

        /// <summary>Specifies whether the variable is optimized away.</summary>
        public bool IsOptimizedAway => symbol.isOptimizedAway;

        /// <summary>Specifies whether the <see langword="this"/> pointer is based on a symbol value.</summary>
        public bool IsPointerBasedOnSymbolValue => symbol.isPointerBasedOnSymbolValue;

        /// <summary>Specifies whether this symbol is a pointer to a data member.</summary>
        public bool IsPointerToDataMember => symbol.isPointerToDataMember;

        /// <summary>Specifies whether this symbol is a pointer to a member function.</summary>
        public bool IsPointerToMemberFunction => symbol.isPointerToMemberFunction;

        /// <summary>Specifies whether the variable carries a return value.</summary>
        public bool IsReturnValue => symbol.isReturnValue;

        /// <summary>Specifies whether the module is compiled with the /SDL option.</summary>
        public bool IsSdl => symbol.isSdl;

        /// <summary>Specifies whether the <see langword="this"/> pointer points to a data member with single inheritance.</summary>
        public bool IsSingleInheritance => symbol.isSingleInheritance;

        /// <summary>Specifies whether the data symbol has been split into an aggregation or collection of other symbols; the compiler treats the symbols as separate entities, even though they are really part of a larger symbol.</summary>
        /// <remarks><see cref="IsAggregated"/> is <see langword="true"/> for all symbols that are part of a split symbol.</remarks>
        public bool IsSplitted => symbol.isSplitted;

        /// <summary>Specifies whether the function or thunk layer has been marked as static.</summary>
        public bool IsStatic => symbol.isStatic;

        /// <summary>Specifies whether the <see langword="this"/> pointer points to a data member with virtual inheritance.</summary>
        public bool IsVirtualInheritance => symbol.isVirtualInheritance;

        /// <summary>The language of the source.</summary>
        public SourceCodeLanguage Language => symbol.language;

        /// <summary>The number of bits or bytes of memory used by the object represented by this symbol.</summary>
        /// <remarks>
        /// If <see cref="LocationType"/> is <see cref="LocationType.IsBitField"/>, the length returned by this method
        /// is in bits; otherwise, the length is in bytes for all other location types.
        /// </remarks>
        public ulong Length => symbol.length;

        /// <summary>The lexical parent of the symbol.</summary>
        /// <remarks>
        /// The lexical parent of a symbol is the enclosing function or module. For example, the lexical parent of
        /// a function parameter or local variable is the function itself while the lexical parent of the function
        /// is the module it is defined in.
        /// </remarks>
        public Symbol? LexicalParent => pdb.GetOrCreateSymbol(symbol.lexicalParent);

        /// <summary>The lexical parent identifier of the symbol.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint LexicalParentID => symbol.lexicalParentId;

        /// <summary>The file name of the library or object file from which the object was loaded.</summary>
        public string LibraryName => symbol.libraryName;

        /// <summary>The length of the address range in which the local symbol is valid.</summary>
        public ulong LiveRangeLength => symbol.liveRangeLength;

        /// <summary>The offset part of the starting address of the range in which the local symbol is valid.</summary>
        /// <remarks>
        /// <para>The address formed by the section and offset is the beginning of the range in which the symbol is valid.</para>
        /// <para>To get the section part of the address, use <see cref="LiveRangeStartAddressSection"/>.</para>
        /// </remarks>
        public uint LiveRangeStartAddressOffset => symbol.liveRangeStartAddressOffset;

        /// <summary>The section part of the starting address of the range in which the local symbol is valid.</summary>
        /// <remarks>
        /// <para>The address formed by the section and offset is the beginning of the range in which the symbol is valid.</para>
        /// <para>To get the offset part of the address, use <see cref="LiveRangeStartAddressOffset"/>.</para>
        /// </remarks>
        public uint LiveRangeStartAddressSection => symbol.liveRangeStartAddressSection;

        /// <summary>The beginning of the address range in which the local symbol is valid.</summary>
        public uint LiveRangeStartRelativeVirtualAddress => symbol.liveRangeStartRelativeVirtualAddress;

        /// <summary>The location type of a data symbol.</summary>
        public LocationType LocationType => symbol.locationType;

        /// <summary>The lower bound of a FORTRAN array dimension.</summary>
        public Symbol? LowerBound => pdb.GetOrCreateSymbol(symbol.lowerBound);

        /// <summary>The symbol identifier of the lower bound of a FORTRAN array dimension.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint LowerBoundID => symbol.lowerBoundId;

        /// <summary>The type of the target CPU.</summary>
        public ImageFileMachine MachineType => symbol.machineType;

        /// <summary>Specifies whether the symbol refers to managed code.</summary>
        public bool Managed => symbol.managed;

        /// <summary>The memory space kind.</summary>
        public uint MemorySpaceKind => symbol.memorySpaceKind;

        /// <summary>Specifies whether the symbol refers to Microsoft Intermediate Language (MSIL) code.</summary>
        public bool Msil => symbol.msil;

        /// <summary>The name of the symbol.</summary>
        public string Name => symbol.name;

        /// <summary>Indicates whether no stack ordering could be done as part of stack buffer checking (/GS (Buffer Security Check) compiler option).</summary>
        public bool NoStackOrdering => symbol.noStackOrdering;

        /// <summary>The number of columns in the matrix.</summary>
        public uint NumberOfColumns => symbol.numberOfColumns;

        /// <summary>The number of modifiers that are applied to the original type.</summary>
        public uint NumberOfModifiers => symbol.numberOfModifiers;

        /// <summary>The number of register indices.</summary>
        public uint NumberOfRegisterIndices => symbol.numberOfRegisterIndices;

        /// <summary>The number of rows in the matrix.</summary>
        public uint NumberOfRows => symbol.numberOfRows;

        /// <summary>The object file name.</summary>
        public string ObjectFileName => symbol.objectFileName;

        /// <summary>The offset of the symbol location.</summary>
        /// <remarks>
        /// <para>Use when <see cref="LocationType"/> is <see cref="LocationType.IsRegRel"/> or <see cref="LocationType.IsBitField"/>.</para>
        /// <para>The offset is from some known point previously determined. For example, the offset for a <see cref="LocationType.IsBitField"/> location type is typically from the start of the containing class.</para>
        /// </remarks>
        public int Offset => symbol.offset;

        /// <summary>The offset to the beginning of a user-defined type (UDT) of a member in the UDT.</summary>
        /// <remarks>This function is used only in local records in an optimized build.</remarks>
        public uint OffsetInUdt => symbol.offsetInUdt;

        /// <summary>The rank (number of dimensions) of a FORTRAN multi-dimensional array.</summary>
        /// <remarks>
        /// Rank refers to the number of dimensions in an array where the array is declared as <c>myarray[1,2,3]</c>.
        /// This example has a rank of 3 and 3 dimensions. Rank does not apply to C++ which uses the concept
        /// of an array of arrays for each dimension (that is, <c>myarray[1][2][3]</c>).
        /// </remarks>
        public uint Rank => symbol.rank;

        /// <summary>Specifies whether a pointer type is a reference.</summary>
        public bool Reference => symbol.reference;

        /// <summary>The register designator of the location when <see cref="LocationType"/> is <see cref="LocationType.IsEnregistered"/>.</summary>
        /// <remarks>
        /// If the symbol is relative to a register, that is, if the symbol's <see cref="LocationType"/> is set to <see cref="LocationType.IsRegRel"/>,
        /// use <see cref="RegisterID"/> followed by <see cref="Offset"/> to get the offset from the register where the symbol is located.
        /// </remarks>
        public uint RegisterID => symbol.registerId;

        /// <summary>The register type.</summary>
        public uint RegisterType => symbol.registerType;

        /// <summary>The relative virtual address (RVA) of the location.</summary>
        /// <remarks>Use when <see cref="LocationType"/> is <see cref="LocationType.IsStatic"/>.</remarks>
        public uint RelativeVirtualAddress => symbol.relativeVirtualAddress;

        /// <summary>Specifies whether the <see langword="this"/> pointer is flagged as restricted.</summary>
        public bool RestrictedType => symbol.restrictedType;

        /// <summary>Specifies whether a pointer type is an rvalue reference.</summary>
        /// <remarks>Use when <see cref="SymbolTag"/> is set to a pointer type.</remarks>
        public bool RValueReference => symbol.RValueReference;

        /// <summary>The sampler slot.</summary>
        public uint SamplerSlot => symbol.samplerSlot;

        /// <summary>Specifies whether the class or method is sealed.</summary>
        /// <remarks>A sealed class cannot be used as a base class. A sealed method cannot be overidden.</remarks>
        public bool Sealed => symbol.@sealed;

        /// <summary>The symbol's signature value.</summary>
        public uint Signature => symbol.signature;

        /// <summary>The size of a member of a user-defined type.</summary>
        public uint SizeInUdt => symbol.sizeInUdt;

        /// <summary>The slot number of the location.</summary>
        /// <remarks>Use when <see cref="LocationType"/> is <see cref="LocationType.IsSlot"/>.</remarks>
        public uint Slot => symbol.slot;

        /// <summary>The stride of the matrix or strided array.</summary>
        public uint Stride => symbol.stride;

        /// <summary>The sub type.</summary>
        public Symbol? SubType => pdb.GetOrCreateSymbol(symbol.subType);

        /// <summary>The sub type ID.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint SubTypeID => symbol.subTypeId;

        /// <summary>The unique symbol identifier.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint SymbolID => symbol.symIndexId;

        /// <summary>The symbol type classifier.</summary>
        public SymbolTag SymbolTag => symbol.symTag;

        /// <summary>The offset section of a thunk target.</summary>
        public uint TargetOffset => symbol.targetOffset;

        /// <summary>The address section of a thunk target.</summary>
        public uint TargetSection => symbol.targetSection;

        /// <summary>The texture slot.</summary>
        public uint TextureSlot => symbol.textureSlot;

        /// <summary>The logical <see langword="this"/> adjustor for the method.</summary>
        /// <remarks>In some multiple inheritance cases the method itself must calculate a true <see langword="this"/> value by adding an offset to <see langword="this"/>.</remarks>
        public int ThisAdjust => symbol.thisAdjust;

        /// <summary>The timestamp of the underlying executable file.</summary>
        public uint TimeStamp => symbol.timeStamp;

        /// <summary>The metadata token of a managed function or variable.</summary>
        public uint Token => symbol.token;

        /// <summary>The symbol that represents the type for this symbol.</summary>
        /// <remarks>
        /// To determine the type a symbol has, you must retrieve this value and examine the resulting Symbol object.
        /// Note that it is possible for a symbol to not have a type. For example, the name of a structure has no type
        /// but it might have children symbols.
        /// </remarks>
        public Symbol? Type => pdb.GetOrCreateSymbol(symbol.type);

        /// <summary>The type identifier of the symbol.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint TypeID => symbol.typeId;

        /// <summary>An array of compiler-specific type identifier values for this symbol.</summary>
        public uint[] TypeIDs
        {
            get
            {
                symbol.getTypeIds(0, out uint cTypeIds, null);

                if (cTypeIds == 0)
                    return Array.Empty<uint>();

                var typeIds = new uint[cTypeIds];
                symbol.getTypeIds(cTypeIds, out _, typeIds);
                return typeIds;
            }
        }

        /// <summary>An array of compiler-specific types for this symbol.</summary>
        public Symbol[] Types
        {
            get
            {
                symbol.getTypes(0, out uint cTypes, null);

                if (cTypes == 0)
                    return Array.Empty<Symbol>();

                var types   = new IDiaSymbol[cTypes];
                var symbols = new Symbol[cTypes];
                symbol.getTypes(cTypes, out _, types);

                for (int i = 0; i < cTypes; i++)
                    symbols[i] = pdb.GetOrCreateSymbol(types[i]);

                return symbols;
            }
        }

        /// <summary>The uav slot.</summary>
        public uint UavSlot => symbol.uavSlot;

        /// <summary>The undecorated name for a C++ decorated, or linkage, name.</summary>
        public string UndecoratedName => symbol.undecoratedName;

        /// <summary>Retrieves part or all of an undecorated name for a C++ decorated (linkage) name.</summary>
        /// <param name="options">Specifies a combination of flags that control what is returned.</param>
        public string GetUndecoratedName(UndecorateOptions options = UndecorateOptions.Complete)
        {
            return symbol.getUndecoratedNameEx(options);
        }

        /// <summary>The original type for this symbol.</summary>
        /// <remarks>
        /// <para>Use when <see cref="SymbolTag"/> is set to a type.</para>
        /// <para>
        /// The current type is a modification of the returned original type.
        /// The original type for a symbol can be determined by first getting
        /// the type of the symbol and then interrogating that returned type
        /// for the original type. Note that some symbols may not have a
        /// modified type of the original type.
        /// </para>
        /// </remarks>
        public Symbol? UnmodifiedType => pdb.GetOrCreateSymbol(symbol.unmodifiedType);

        /// <summary>The ID of the original (unmodified) type.</summary>
        public uint UnmodifiedTypeID => symbol.unmodifiedTypeId;

        /// <summary>A symbol representing the upper bound of a FORTRAN array dimension.</summary>
        public Symbol? UpperBound => pdb.GetOrCreateSymbol(symbol.upperBound);

        /// <summary>The symbol identifier of the upper bound of a FORTRAN array dimension.</summary>
        /// <remarks>The identifier is a unique value created by the DIA SDK to mark all symbols as unique.</remarks>
        public uint UpperBoundID => symbol.upperBoundId;

        /// <summary>The value of a constant.</summary>
        public object Value => symbol.value;

        /// <summary>The virtual address (VA) of the location.</summary>
        /// <remarks>Use when <see cref="LocationType"/> is <see cref="LocationType.IsStatic"/>.</remarks>
        public IntPtr VirtualAddress => new IntPtr((long)symbol.virtualAddress);

        /// <summary>The index of the symbol in the virtual base displacement table.</summary>
        public uint VirtualBaseDisplacementIndex => symbol.virtualBaseDispIndex;

        /// <summary>The type of a virtual base table pointer.</summary>
        /// <remarks>
        /// <para>
        /// A virtual base table pointer (<c>vbtptr</c>) is a hidden pointer in a Visual C++ vtable that handles
        /// inheritance from virtual base classes. A <c>vbtptr</c> can have different sizes depending on the inherited classes.
        /// </para>
        /// <para>This method returns a Symbol object that can be used to determine the size of the <c>vbtptr</c>.</para>
        /// </remarks>
        public Symbol? VirtualBaseTableType => pdb.GetOrCreateSymbol(symbol.virtualBaseTableType);

        /// <summary>The offset of the virtual base pointer.</summary>
        public int VirtualBasePointerOffset => symbol.virtualBasePointerOffset;

        /// <summary>Retrieves the children of the symbol. The local symbols that are returned include live range information, if the program is compiled with optimization on.</summary>
        /// <param name="tag">Specifies the symbol tags of the children to be retrieved, as defined in the <see cref="Dia2.SymbolTag"/> enum. Set to <see cref="SymbolTag.Null"/> for all children to be retrieved.</param>
        /// <param name="name">Specifies the name of the children to be retrieved. Set to <see langword="null"/> for all children to be retrieved.</param>
        /// <param name="options">Specifies the comparison options to be applied to name matching.</param>
        public IEnumerable<Symbol> FindChildren(SymbolTag tag, string? name, NameSearchOptions options)
        {
            return EnumerateSymbols<Symbol>(symbol.findChildrenEx(tag, name, options));
        }

        /// <summary>Retrieves the children of the symbol. The local symbols that are returned include live range information, if the program is compiled with optimization on.</summary>
        /// <param name="name">Specifies the name of the children to be retrieved. Set to <see langword="null"/> for all children to be retrieved.</param>
        /// <param name="options">Specifies the comparison options to be applied to name matching.</param>
        public IEnumerable<T> FindChildren<T>(string? name, NameSearchOptions options)
            where T : Symbol
        {
            return EnumerateSymbols<T>(symbol.findChildrenEx(s_Tags[typeof(T)], name, options));
        }

        /// <summary>Retrieves the children of the symbol that are valid at a specified virtual address.</summary>
        /// <param name="tag">Specifies the symbol tags of the children to be retrieved, as defined in the <see cref="Dia2.SymbolTag"/> enum. Set to <see cref="SymbolTag.Null"/> for all children to be retrieved.</param>
        /// <param name="name">Specifies the name of the children to be retrieved. Set to <see langword="null"/> for all children to be retrieved.</param>
        /// <param name="options">Specifies the comparison options to be applied to name matching.</param>
        /// <param name="address">Specifies the virtual address.</param>
        public IEnumerable<Symbol> FindChildrenByVA(SymbolTag tag, string? name, NameSearchOptions options, ulong address)
        {
            return EnumerateSymbols<Symbol>(symbol.findChildrenExByVA(tag, name, options, address));
        }

        /// <summary>Retrieves the children of the symbol that are valid at a specified virtual address.</summary>
        /// <param name="name">Specifies the name of the children to be retrieved. Set to <see langword="null"/> for all children to be retrieved.</param>
        /// <param name="options">Specifies the comparison options to be applied to name matching.</param>
        /// <param name="address">Specifies the virtual address.</param>
        public IEnumerable<T> FindChildrenByVA<T>(string? name, NameSearchOptions options, ulong address)
            where T : Symbol
        {
            return EnumerateSymbols<T>(symbol.findChildrenExByVA(s_Tags[typeof(T)], name, options, address));
        }

        /// <summary>Retrieves the children of the symbol that are valid at a specified relative virtual address (RVA).</summary>
        /// <param name="tag">Specifies the symbol tags of the children to be retrieved, as defined in the <see cref="Dia2.SymbolTag"/> enum. Set to <see cref="SymbolTag.Null"/> for all children to be retrieved.</param>
        /// <param name="name">Specifies the name of the children to be retrieved. Set to <see langword="null"/> for all children to be retrieved.</param>
        /// <param name="options">Specifies the comparison options to be applied to name matching.</param>
        /// <param name="address">Specifies the RVA.</param>
        public IEnumerable<Symbol> FindChildrenByRVA(SymbolTag tag, string? name, NameSearchOptions options, uint address)
        {
            return EnumerateSymbols<Symbol>(symbol.findChildrenExByRVA(tag, name, options, address));
        }

        /// <summary>Retrieves the children of the symbol that are valid at a specified relative virtual address (RVA).</summary>
        /// <param name="name">Specifies the name of the children to be retrieved. Set to <see langword="null"/> for all children to be retrieved.</param>
        /// <param name="options">Specifies the comparison options to be applied to name matching.</param>
        /// <param name="address">Specifies the RVA.</param>
        public IEnumerable<T> FindChildrenByRVA<T>(string? name, NameSearchOptions options, uint address)
            where T : Symbol
        {
            return EnumerateSymbols<T>(symbol.findChildrenExByRVA(s_Tags[typeof(T)], name, options, address));
        }

        IEnumerable<T> EnumerateSymbols<T>(IDiaEnumSymbols enumerator)
            where T : Symbol
        {
            try
            {
                foreach (IDiaSymbol symbol in enumerator)
                {
                    yield return (T)pdb.GetOrCreateSymbol(symbol);
                }
            }
            finally
            {
                Marshal.ReleaseComObject(enumerator);
            }
        }

        internal Symbol(Pdb pdb, IDiaSymbol symbol)
        {
            this.pdb    = pdb;
            this.symbol = symbol;
        }

        public bool Equals(Symbol? other)
        {
            return SymbolID == other?.SymbolID;
        }

        public override bool Equals(object? obj)
        {
            return obj is Symbol other && Equals(other);
        }

        public override int GetHashCode()
        {
            return SymbolID.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        static readonly Dictionary<Type, SymbolTag> s_Tags = new()
        {
            { typeof(Symbol), SymbolTag.Null },
            { typeof(ExeSymbol), SymbolTag.Exe },
            { typeof(CompilandSymbol), SymbolTag.Compiland },
            { typeof(CompilandDetailsSymbol), SymbolTag.CompilandDetails },
            { typeof(CompilandEnvironmentSymbol), SymbolTag.CompilandEnv },
            { typeof(FunctionSymbol), SymbolTag.Function },
            { typeof(BlockSymbol), SymbolTag.Block },
            { typeof(DataSymbol), SymbolTag.Data },
            { typeof(AnnotationSymbol), SymbolTag.Annotation },
            { typeof(LabelSymbol), SymbolTag.Label },
            { typeof(PublicSymbol), SymbolTag.PublicSymbol },
            { typeof(UserDefinedTypeSymbol), SymbolTag.UDT },
            { typeof(EnumSymbol), SymbolTag.Enum },
            { typeof(FunctionTypeSymbol), SymbolTag.FunctionType },
            { typeof(PointerTypeSymbol), SymbolTag.PointerType },
            { typeof(ArrayTypeSymbol), SymbolTag.ArrayType },
            { typeof(BaseTypeSymbol), SymbolTag.BaseType },
            { typeof(TypedefSymbol), SymbolTag.Typedef },
            { typeof(BaseClassSymbol), SymbolTag.BaseClass },
            { typeof(FriendSymbol), SymbolTag.Friend },
            { typeof(FunctionArgumentTypeSymbol), SymbolTag.FunctionArgType },
            { typeof(FunctionDebugStartSymbol), SymbolTag.FuncDebugStart },
            { typeof(FunctionDebugEndSymbol), SymbolTag.FuncDebugEnd },
            { typeof(UsingNamespaceSymbol), SymbolTag.UsingNamespace },
            { typeof(VTableShapeSymbol), SymbolTag.VTableShape },
            { typeof(VTableSymbol), SymbolTag.VTable },
            { typeof(CustomSymbol), SymbolTag.Custom },
            { typeof(ThunkSymbol), SymbolTag.Thunk },
            { typeof(CustomTypeSymbol), SymbolTag.CustomType },
            { typeof(ManagedTypeSymbol), SymbolTag.ManagedType },
            { typeof(DimensionSymbol), SymbolTag.Dimension },
            { typeof(CallSiteSymbol), SymbolTag.CallSite },
            { typeof(InlineSiteSymbol), SymbolTag.InlineSite },
            { typeof(BaseInterfaceSymbol), SymbolTag.BaseInterface },
            { typeof(VectorTypeSymbol), SymbolTag.VectorType },
            { typeof(MatrixTypeSymbol), SymbolTag.MatrixType },
            { typeof(HlslTypeSymbol), SymbolTag.HLSLType }
        };
    }
}
