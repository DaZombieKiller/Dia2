using System;
using System.Runtime.InteropServices;

namespace Dia2.ComInterfaces
{
    [ComImport]
    [Guid("2F609EE1-D1C8-4E24-8288-3326BADCD211")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IDiaSession
    {
        ulong loadAddress { get; set; }
        IDiaSymbol globalScope { get; }
        IDiaEnumTables getEnumTables();
        IDiaEnumSymbolsByAddr getSymbolsByAddr();
        IDiaEnumSymbols findChildren(IDiaSymbol parent, SymbolTag symtag, string name, NameSearchOptions compareFlags);
        IDiaEnumSymbols findChildrenEx(IDiaSymbol parent, SymbolTag symtag, string name, NameSearchOptions compareFlags);
        IDiaEnumSymbols findChildrenExByAddr(IDiaSymbol parent, SymbolTag symtag, string name, NameSearchOptions compareFlags, uint isect, uint offset);
        IDiaEnumSymbols findChildrenExByVA(IDiaSymbol parent, SymbolTag symtag, string name, NameSearchOptions compareFlags, ulong va);
        IDiaEnumSymbols findChildrenExByRVA(IDiaSymbol parent, SymbolTag symtag, string name, NameSearchOptions compareFlags, uint rva);
        // To-do...
    }
}
