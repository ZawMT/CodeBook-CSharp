using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Cs_Config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConfig_Click(object sender, EventArgs e)
        {
            string? strK0 = ConfigurationManager.AppSettings.Get("Key0");
            MessageBox.Show(strK0);
        }
    }
}
