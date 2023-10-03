using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _24_CS_BusyIndicatorInAPopup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ShowBusyIndicatorWindow()
        {
            var busyWindow = new Window
            {
                Title = "Busy Indicator",
                Content = new Busy(), // Replace with the name of your busy indicator window class
                WindowStyle = WindowStyle.None,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = Application.Current.MainWindow, // Set the owner to the main window or another appropriate window
                ShowInTaskbar = false,
                Width = 300,
                Height = 200
            };

            busyWindow.ShowDialog(); // Show the busy window modally
        }

    }
}
