using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("4A59FB77-ABAC-469b-A30B-9ECC85BFEF14")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaTable : IEnumUnknown
    {
        IEnumerator GetEnumerator();
        string name { get; }
        int Count { get; }
        [return: MarshalAs(UnmanagedType.IUnknown)]
        object Item(uint index);
    }
}
