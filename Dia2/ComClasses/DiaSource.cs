using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Dia2.ComInterfaces;

namespace Dia2.ComClasses
{
    [Guid("e6756135-1e65-4d17-8576-610761398c3c")]
    abstract class DiaSource : IDiaDataSource
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
