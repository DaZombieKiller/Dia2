using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("C65C2B0A-1150-4d7a-AFCC-E05BF3DEE81E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaEnumTables
    {
        IEnumerator GetEnumerator();
        int Count { get; }
        IDiaTable? Item(object index);
        void Next(uint celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDiaTable[] rgelt, out uint pceltFetched);
        void Skip(uint celt);
        void Reset();
        IDiaEnumTables Clone();
    }
}
