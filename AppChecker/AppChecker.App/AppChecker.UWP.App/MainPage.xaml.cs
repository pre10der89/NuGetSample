using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AppChecker.App
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
            var testDriver = new TestDriver();

            string results = testDriver.RunTest();

            if (textBlock != null)
            {
                textBlock.Text = results;
            }
        }
    }
}
