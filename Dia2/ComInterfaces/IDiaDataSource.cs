using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("79F1BB5F-B66E-48e5-B6A9-1545C323CA3D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaDataSource
    {
        string lastError { get; }
        void loadDataFromPdb(string pdbPath);
        void loadAndValidateDataFromPdb(string pdbPath, in Guid pcsig70, uint sig, uint age);
        void loadDataForExe(string executable, string? searchPath, [MarshalAs(UnmanagedType.IUnknown)] object? pCallback);
        void loadDataFromIStream(IStream pIStream);
        IDiaSession openSession();
        void loadDataFromCodeViewInfo(string executable, string? searchPath, uint cbCvInfo, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbCvInfo, [MarshalAs(UnmanagedType.IUnknown)] object pCallback);
        void loadDataFromMiscInfo(string executable, string? searchPath, uint timeStampExe, uint timeStampDbg, uint sizeOfExe, uint cbMiscInfo, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] pbMiscInfo, [MarshalAs(UnmanagedType.IUnknown)] object pCallback);
    }
}
