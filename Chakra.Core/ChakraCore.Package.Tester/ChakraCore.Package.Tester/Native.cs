using System;
using System.Runtime.InteropServices;

namespace ChakraCore.Package.Tester
{
    class Native
    {
        private const string DllName = "ChakraCore";

        [DllImport(DllName, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int JsAddRef(IntPtr value, IntPtr count);
    }
}
