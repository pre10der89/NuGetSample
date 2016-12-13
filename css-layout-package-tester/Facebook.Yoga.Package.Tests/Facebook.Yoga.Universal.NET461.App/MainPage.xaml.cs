using Facebook.Yoga.Package.Tests;
using Windows.UI.Xaml.Controls;

namespace Facebook.Yoga.App
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TestDriver testDriver = new TestDriver();

            string result;

            bool success = testDriver.RunSanityCheck(out result);

            if (textBlock != null)
            {
                textBlock.Text = result;
            }
        }
    }
}
