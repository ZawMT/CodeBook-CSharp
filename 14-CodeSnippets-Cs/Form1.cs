using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CodeSnippets_Cs
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStripEdge_Click(object sender, EventArgs e)
        {
            string strText = txtInput1.Text;
            string strToStrip = txtInput2.Text;
            string strAns = "";
            int iLenStrip = strToStrip.Length;
            if (iLenStrip == 0)
                strAns = strText;

            bool bPreDone = false;
            bool bPostDone = false;
            bool bRepeat = false;
            bool bDone = false;
            do
            {
                bDone = bPreDone & bPostDone;
                if (!bPreDone && strToStrip.CompareTo(strText.Substring(0, iLenStrip)) == 0)
                {
                    strText = strText.Substring(iLenStrip);
                    if (!bRepeat)
                        bPreDone = true;
                }
                else
                    bPreDone = true;

                if (!bPostDone && strToStrip.CompareTo(strText.Substring(strText.Length - iLenStrip)) == 0)
                {
                    strText = strText.Substring(0, strText.Length - iLenStrip);
                    if (!bRepeat)
                        bPostDone = true;
                }
                else
                    bPostDone = true;
            } while (!bDone);

            strAns = strText;

            txtInput3.Text = strAns;
        }
    }
}
