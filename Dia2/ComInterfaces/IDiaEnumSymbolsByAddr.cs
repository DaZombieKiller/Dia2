using System;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaEnumSymbolsByAddr
    {
        IDiaSymbol? symbolByAddr(uint isect, uint offset);
        IDiaSymbol? symbolByRVA(uint relativeVirtualAddress);
        IDiaSymbol? symbolByVA(ulong virtualAddress);
        void Next(uint celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDiaSymbol[] rgelt, out uint pceltFetched);
        void Prev(uint celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDiaSymbol[] rgelt, out uint pceltFetched);
        IDiaEnumSymbolsByAddr Clone();
    }
}
