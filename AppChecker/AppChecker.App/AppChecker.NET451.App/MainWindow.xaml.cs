using System.Windows;

namespace AppChecker.App
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
            var testDriver = new TestDriver();

            string results = testDriver.RunTest();

            if (textBlock != null)
            {
                textBlock.Text = results;
            }
        }
    }
}
