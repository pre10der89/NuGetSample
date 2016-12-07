using System.Runtime.InteropServices;

namespace AppCheckerSDK
{
    internal static class Native
    {
        private const string DllName = "AppCheckerNative";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ProcessorArchitecture GetArchitecture();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Bitness GetBitness();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Bitness GetBitnessByIntSize();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern OSType GetOSType();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Test();
    }
}
