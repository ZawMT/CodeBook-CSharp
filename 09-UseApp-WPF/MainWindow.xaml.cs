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

using _09_Lib_CSClass;
using _09_Lib_CSNetFw;
using _09_Lib_CSWPF;

namespace _09_UseApp_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _09_Lib_CSClass.SuperMaths superMaths = new _09_Lib_CSClass.SuperMaths();            
            btnTest.Content = superMaths.Add("TEST", "- OK 1");
        }

        private void btnWPFLib_Click(object sender, RoutedEventArgs e)
        {
            _09_Lib_CSWPF.SuperMaths superMaths = new _09_Lib_CSWPF.SuperMaths();
            btnWPFLib.Content = superMaths.Add("TEST", " - OK 2");
        }

        private void btnNetFwLib_Click(object sender, RoutedEventArgs e)
        {
            _09_Lib_CSNetFw.SuperMaths superMaths = new _09_Lib_CSNetFw.SuperMaths();
            btnNetFwLib.Content = superMaths.Add("TEST", " - OK 3");
        }
    }
}
