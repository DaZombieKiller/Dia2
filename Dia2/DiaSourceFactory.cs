using System;
using System.Runtime.InteropServices;
using Dia2.ComInterfaces;
using Dia2.ComClasses;

namespace Dia2
{
    static class DiaSourceFactory
    {
        [DllImport(DiaDllResolver.LibraryName, PreserveSig = false, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.IUnknown)]
        static extern object? DllGetClassObject(in Guid classId, in Guid interfaceId);

        static T? DllGetClassObject<T>(in Guid classId)
            where T : class
        {
            return DllGetClassObject(classId, typeof(T).GUID) as T;
        }

        static T? CreateInstance<T>(this IClassFactory factory, object? outer)
            where T : class
        {
            return factory.CreateInstance(outer, typeof(T).GUID) as T;
        }

        public static IDiaDataSource CreateInstance()
        {
            var factory = DllGetClassObject<IClassFactory>(typeof(DiaSource).GUID);
            return factory!.CreateInstance<IDiaDataSource>(null)!;
        }

        public static IDiaDataSource CreateAltInstance()
        {
            var factory = DllGetClassObject<IClassFactory>(typeof(DiaSourceAlt).GUID);
            return factory!.CreateInstance<IDiaDataSource>(null)!;
        }
    }
}
