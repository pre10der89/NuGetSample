namespace AppCheckerSDK
{
    public class AppCheckerTool
    {
        public void Test()
        {
            Native.Test();
        }

        public ProcessorArchitecture GetArchitecture()
        {
            return Native.GetArchitecture();
        }

        public Bitness GetBitness()
        {
            return Native.GetBitness();
        }

        public Bitness GetBitnessByIntSize()
        {
            return Native.GetBitnessByIntSize();
        }

        public OSType GetOSType()
        {
            return Native.GetOSType();
        }

        public bool IsX86()
        {
            return (Native.GetArchitecture() == ProcessorArchitecture.X86);
        }

        public bool IsX64()
        {
            return (Native.GetArchitecture() == ProcessorArchitecture.X64);
        }

        public bool IsARM()
        {
            return (Native.GetArchitecture() == ProcessorArchitecture.ARM);
        }

        public bool Is32BitProcess()
        {
            return (Native.GetBitness() == Bitness._32Bit);
        }

        public bool Is64BitProcess()
        {
            return (Native.GetBitness() == Bitness._64Bit);
        }

        public bool IsWin7()
        {
            OSType osType = Native.GetOSType();

            return ((osType == OSType.win7 || osType == OSType.win7_x86 || osType == OSType.win7_x64 || osType == OSType.win7_arm));
        }

        public bool IsWin8()
        {
            OSType osType = Native.GetOSType();

            return ((osType == OSType.win8 || osType == OSType.win8_x86 || osType == OSType.win8_x64 || osType == OSType.win8_arm));
        }

        public bool IsWin81()
        {
            OSType osType = Native.GetOSType();

            return ((osType == OSType.win81 || osType == OSType.win81_x86 || osType == OSType.win81_x64 || osType == OSType.win81_arm));
        }

        public bool IsWin10()
        {
            OSType osType = Native.GetOSType();

            return ((osType == OSType.win10 || osType == OSType.win10_x86 || osType == OSType.win10_x64 || osType == OSType.win10_arm));
        }
    }
}
