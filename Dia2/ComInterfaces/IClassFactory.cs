using System;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("00000001-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IClassFactory
    {
        [return: MarshalAs(UnmanagedType.IUnknown)]
        object? CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object? outer, in Guid interfaceId);
        void LockServer(bool @lock);
    }
}
