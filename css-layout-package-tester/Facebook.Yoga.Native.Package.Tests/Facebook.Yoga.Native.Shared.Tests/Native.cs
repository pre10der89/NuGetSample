using System.Runtime.InteropServices;

namespace Facebook.Yoga.Native.Package.Tests
{
    class Native
    {
        private const string DllName = "yoga";

        [DllImport(DllName, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool YGIsExperimentalFeatureEnabled(YogaExperimentalFeature feature);

    }
}
