using System;
using System.Windows;
using AppCheckerSDK;

namespace AppChecker.NETStandard.App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string results = "Success";
            string NativeLibraryResults = "";
            string EnvironmentResults = "";

            try
            {
                var appChecker = new AppCheckerTool();

                var architecture = appChecker.GetArchitecture();
                var bitness = appChecker.GetBitness();
                var bitness2 = appChecker.GetBitness();
                var osType = appChecker.GetOSType();

                NativeLibraryResults = string.Format("Architecture: {0} - ProcessBitness: {1},{2} - OSType: {3}", architecture, bitness, bitness2, osType);


                EnvironmentResults = string.Format("ProcessBitness: {0} - OSType: {1}", Environment.Is64BitProcess ? "64Bit" : "32Bit", Environment.Is64BitOperatingSystem ? "64Bit" : "32Bit");

                results = string.Format("NativeLibrary = {0}{1}Enviornment = {2}", NativeLibraryResults, Environment.NewLine + Environment.NewLine, EnvironmentResults);
            }
            catch (Exception ex)
            {
                results = ex.Message + Environment.NewLine + ex.StackTrace;
            }

            if (textBlock != null)
            {
                textBlock.Text = results;
            }
        }
    }
}
