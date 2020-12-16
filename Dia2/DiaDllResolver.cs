using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Dia2
{
    static class DiaDllResolver
    {
        public const string LibraryName = "msdia";

        const string DllVersion = "140";

        const string DllName = LibraryName + DllVersion;

        const string DllNameX64 = DllName + ".amd64";

        [ModuleInitializer]
        public static void Initialize()
        {
            NativeLibrary.SetDllImportResolver(typeof(DiaDllResolver).Assembly, Resolve);
        }

        static string GetDllName()
        {
            if (Environment.Is64BitProcess)
                return DllNameX64;
            else
                return DllName;
        }

        static IntPtr Resolve(string name, Assembly assembly, DllImportSearchPath? searchPath)
        {
            return name switch
            {
                LibraryName => NativeLibrary.Load(GetDllName(), assembly, searchPath),
                _           => IntPtr.Zero
            };
        }
    }
}
