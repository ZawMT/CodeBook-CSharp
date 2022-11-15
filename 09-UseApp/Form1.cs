using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _09_Lib_CSNetFw;

namespace _09_UseApp
{
    public partial class Form1 : Form
    {
        private SuperMaths superMaths;
        public Form1()
        {
            InitializeComponent();
            superMaths = new SuperMaths();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAns.Text = superMaths.Add(txtParam1.Text, txtParam2.Text);
        }
    }
}
