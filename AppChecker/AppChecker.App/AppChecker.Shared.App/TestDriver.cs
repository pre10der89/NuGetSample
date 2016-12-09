using AppCheckerSDK;
using System;

namespace AppChecker.App
{
    public class TestDriver
    {
        public string RunTest()
        {
            string results = "";

            try
            {
                var appChecker = new AppCheckerTool();

                var architecture = appChecker.GetArchitecture();
                var bitness = appChecker.GetBitness();
                var bitness2 = appChecker.GetBitness();
                var osType = appChecker.GetOSType();

                results = string.Format("FromNativeLibrary ==> Architecture: {0} - ProcessBitness: {1},{2} - OSType: {3}", architecture, bitness, bitness2, osType);

#if !WINDOWS_UWP
                string environmentResults = string.Format("ProcessBitness: {0} - OSType: {1}", Environment.Is64BitProcess ? "64Bit" : "32Bit", Environment.Is64BitOperatingSystem ? "64Bit" : "32Bit");

                results += Environment.NewLine + Environment.NewLine + "FromEnviornment ==> " + environmentResults;
#endif
            }
            catch (Exception ex)
            {
                results = ex.Message + Environment.NewLine + ex.StackTrace;
            }

            return results;
        }
    }
}
