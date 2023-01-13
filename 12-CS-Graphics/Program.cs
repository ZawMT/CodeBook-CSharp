using System;
using System.Windows.Forms;

namespace _12_CS_Graphics
{
    /*
     * This chapter demonstrates some basic information about using image / grphics in C#.
     * One point to take note is that the handling of graphics and operations (e.g. drawing a text on an image) can be 
     * different from one environment to another. For example, the X, Y used here in C# might not be applicable
     * to Python's Pillow: reason is the stype of locating of the text's XY might not be exactly the same.
     * */
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
