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
using System.Windows.Threading;

namespace _03_WPF_Thread
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void NextRotateDelegate();
        private bool continueRotate;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRotate1_Click(object sender, RoutedEventArgs e)
        {
            // This function will cause the error
            // The reason is - Task will access the UI elements which are owned by the UI thread so the violation happens

            if (continueRotate)
            {
                continueRotate = false;
                btnRotate1.Content = "Start rotation";
            }
            else
            {
                continueRotate = true;
                btnRotate1.Content = "Stop rotation";                
                Task.Delay(1000).ContinueWith(_ =>
                    {
                        fnRotateImage1();
                    }
                );
            }
        }
        private void fnRotateImage1()
        {
            double iNewAngle = rtTest.Angle + 5.0;
            if (iNewAngle >= 360.0)
                iNewAngle = 0.0;
            rtTest.Angle = iNewAngle;
        }

        private void btnRotate2_Click(object sender, RoutedEventArgs e)
        {
            // To avoid the error of btnRotate1, a delegate is created => NextRotateDelegate
            // UI activity is invoked through the Dispatcher of btnRotation2

            if (continueRotate)
            {
                continueRotate = false;
                btnRotate2.Content = "Start rotation";
            }
            else
            {
                continueRotate = true;
                btnRotate2.Content = "Stop rotation";
                btnRotate2.Dispatcher.BeginInvoke(
                    DispatcherPriority.Normal,
                    new NextRotateDelegate(fnRotateImage2));
            }
        }

        private void fnRotateImage2()
        {
            double iNewAngle = rtTest.Angle + 1.0;
            if (iNewAngle >= 360.0)
                iNewAngle = 0.0;
            rtTest.Angle = iNewAngle;

            if (continueRotate)
            {
                btnRotate2.Dispatcher.BeginInvoke(
                    DispatcherPriority.SystemIdle,
                    new NextRotateDelegate(fnRotateImage2));
            }
        }
    }
}
