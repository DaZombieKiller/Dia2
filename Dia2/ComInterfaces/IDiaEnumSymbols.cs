using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("CAB72C48-443B-48f5-9B0B-42F0820AB29A")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaEnumSymbols
    {
        IEnumerator GetEnumerator();
        int Count { get; }
        IDiaSymbol? Item(uint index);
        void Next(uint celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDiaSymbol[] rgelt, out uint pceltFetched);
        void Skip(uint celt);
        void Reset();
        IDiaEnumSymbols Clone();
    }
}
