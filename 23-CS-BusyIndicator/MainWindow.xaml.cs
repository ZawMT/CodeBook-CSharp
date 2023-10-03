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

namespace _23_CS_BusyIndicator
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
            bsy.IsBusy = true;
            
            // This will freeze the whole UI while busy
            // SetBusyState(true);
        }

        private void SetBusyState(bool isBusy)
        {
            if (isBusy)
            {
                Mouse.OverrideCursor = Cursors.Wait;
                Application.Current.MainWindow.IsEnabled = false;
            }
            else
            {
                Mouse.OverrideCursor = null;
                Application.Current.MainWindow.IsEnabled = true;
            }
        }

        private void bsy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SetBusyState(false);
        }
    }
}
