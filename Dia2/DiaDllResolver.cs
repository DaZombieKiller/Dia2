using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Dia2
{
    static class DiaDllResolver
    {
        public const string LibraryName = "msdia";

        const string LibraryNameX86 = "msdia140";

        const string LibraryNameX64 = "msdia140.amd64";

        [ModuleInitializer]
        public static void Initialize()
        {
            NativeLibrary.SetDllImportResolver(typeof(DiaDllResolver).Assembly, Resolve);
        }

        static IntPtr Resolve(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
        {
            if (libraryName != LibraryName)
                return IntPtr.Zero;

            if (Environment.Is64BitProcess)
                libraryName = LibraryNameX64;
            else
                libraryName = LibraryNameX86;

            return NativeLibrary.Load(libraryName, assembly, searchPath);
        }
    }
}
