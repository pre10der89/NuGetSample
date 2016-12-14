using System;
using System.Windows;

namespace ChakraCore.Package.Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string result = "Success";

            try
            {
                IntPtr count = new IntPtr(2);
                Native.JsAddRef(default(IntPtr), count);
            }
            catch(Exception ex)
            {
                result = ex.Message + Environment.NewLine + ex.StackTrace;
            }

            if ( textBlock != null )
            {
                textBlock.Text = result;
            }
        }
    }
}
