using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using AppCheckerSDK;

namespace AppChecker.Universal.App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string results = "Success";
            string NativeLibraryResults = "";

            try
            {
                var appChecker = new AppCheckerTool();

                var architecture = appChecker.GetArchitecture();
                var bitness = appChecker.GetBitness();
                var bitness2 = appChecker.GetBitness();
                var osType = appChecker.GetOSType();

                NativeLibraryResults = string.Format("Architecture: {0} - ProcessBitness: {1},{2} - OSType: {3}", architecture, bitness, bitness2, osType);

                results = string.Format("NativeLibrary = {0}", NativeLibraryResults);
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
