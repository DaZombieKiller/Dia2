using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Dia2.ComInterfaces;

namespace Dia2.ComClasses
{
    [Guid("91904831-49ca-4766-b95c-25397e2dd6dc")]
    abstract class DiaSourceAlt : IDiaDataSource
    {
        public abstract string lastError { get; }
        public abstract void loadDataFromPdb(string pdbPath);
        public abstract void loadAndValidateDataFromPdb(string pdbPath, in Guid pcsig70, uint sig, uint age);
        public abstract void loadDataForExe(string executable, string searchPath, [MarshalAs(UnmanagedType.IUnknown)] object pCallback);
        public abstract void loadDataFromIStream(IStream pIStream);
        public abstract IDiaSession openSession();
        public abstract void loadDataFromCodeViewInfo(string executable, string searchPath, uint cbCvInfo, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbCvInfo, [MarshalAs(UnmanagedType.IUnknown)] object pCallback);
        public abstract void loadDataFromMiscInfo(string executable, string searchPath, uint timeStampExe, uint timeStampDbg, uint sizeOfExe, uint cbMiscInfo, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] pbMiscInfo, [MarshalAs(UnmanagedType.IUnknown)] object pCallback);
    }
}
