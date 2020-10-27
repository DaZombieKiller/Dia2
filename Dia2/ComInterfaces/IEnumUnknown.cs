using System;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("00000100-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IEnumUnknown
    {
        void Next(uint celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] object[] rgelt, out uint pceltFetched);
        void Skip(uint celt);
        void Reset();
        IEnumUnknown Clone();
    }
}
