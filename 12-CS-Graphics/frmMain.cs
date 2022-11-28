using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _12_CS_Graphics
{
    public partial class frmMain : Form
    {
        List<RenderText> vRTexts;

        private Bitmap bmpCurrent;
        private string strFilename = "";
        public frmMain()
        {
            InitializeComponent();
            vRTexts = new List<RenderText>();
            enableControls(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdTmp = new OpenFileDialog();
            DialogResult drTmp = ofdTmp.ShowDialog();
            if(drTmp == DialogResult.OK)
            {
                if(bmpCurrent != null)
                    bmpCurrent.Dispose();
                string strTmpPath = Path.GetDirectoryName(Application.ExecutablePath) + "/tmp/";
                strFilename = strTmpPath + Path.GetFileName(ofdTmp.FileName);
                File.Copy(ofdTmp.FileName, strFilename, true);
                bmpCurrent = (Bitmap)Image.FromFile(strFilename);
                pBoxMain.Image = bmpCurrent;

                enableControls();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restartRender();
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            if (bmpCurrent != null)
            {
                int iSel = cboRenderTexts.SelectedIndex;
                if (vRTexts != null && vRTexts.Count > iSel)
                {
                    RenderText rtTmp = vRTexts[iSel];
                    startRender(rtTmp);
                }
                else
                    MessageBox.Show("Select a text to render from the list combo!!!");
            }
            else
                MessageBox.Show("Load an image first!!!");
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            string strTextname = Interaction.InputBox("Give a name to the text", "Text name");
            if(strTextname != null && strTextname.Length>0)
            {
                RenderText rtTmp = new RenderText(strTextname);
                if (!existRenderText(rtTmp))
                {
                    vRTexts.Add(rtTmp);
                    setRenderText(rtTmp);
                    updateRenderTextListInCombo();                    
                }
                else
                    MessageBox.Show("Entry already exists!!!");
            }
        }

        private void cboRenderTexts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSel = cboRenderTexts.SelectedIndex;
            if(vRTexts != null && vRTexts.Count > iSel)
            {
                RenderText rtTmp = vRTexts[iSel];
                txtX.Text = rtTmp.X.ToString();
                txtY.Text = rtTmp.Y.ToString();
                txtSize.Text = rtTmp.Size.ToString();
                txtText.Text = rtTmp.Text;
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool bFound = false;
            int iIndx = -1;
            foreach (RenderText rt in vRTexts)
            {
                iIndx++;
                if (rt.Name.CompareTo(cboRenderTexts.Text) == 0)
                {
                    bFound = true;
                    break;
                }
            }

            if (bFound)
            {
                vRTexts.RemoveAt(iIndx);
                updateRenderTextListInCombo(iIndx);
            }
        }

        private void btnRRender_Click(object sender, EventArgs e)
        {
            restartRender();
            foreach(RenderText rt in vRTexts)
                startRender(rt);
        }

        private void pBoxMain_Click(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                var imagePos = e.Location;
                int iX = (int)(imagePos.X * (((float)bmpCurrent.Width) / (float)pBoxMain.Width));
                int iY = (int)(imagePos.Y * (((float)bmpCurrent.Height) / (float)pBoxMain.Height));
                txtX.Text = iX.ToString();
                txtY.Text = iY.ToString();
            }
        }

        private void saveRenderText()
        {
            int iSel = cboRenderTexts.SelectedIndex;
            if (iSel>=0 && vRTexts != null && vRTexts.Count > iSel)
            {
                short iTmp;
                RenderText rtTmp = vRTexts[iSel];
                rtTmp.X = Int16.TryParse(txtX.Text, out iTmp) ? Int16.Parse(txtX.Text) : 0;
                rtTmp.Y = Int16.TryParse(txtY.Text, out iTmp) ? Int16.Parse(txtY.Text) : 0;
                rtTmp.Size = Int16.TryParse(txtSize.Text, out iTmp) ? Int16.Parse(txtSize.Text) : 0;
                rtTmp.Text = txtText.Text;
                vRTexts[iSel] = rtTmp;
                if(rtTmp.Text.Length == 0)
                {
                    int i = 9;
                    i++;
                }
            }
        }

        private void setRenderText(RenderText rt)
        {
            txtX.Text = rt.X.ToString();
            txtY.Text = rt.Y.ToString();
            txtSize.Text = rt.Size.ToString();
            txtText.Text = rt.Text;
        }

        private void restartRender()
        {
            if (strFilename.Length > 0)
            {
                bmpCurrent = (Bitmap)Image.FromFile(strFilename);
                pBoxMain.Image = bmpCurrent;
            }
        }

        private void startRender(RenderText rtTmp)
        {
            if (bmpCurrent != null)
            {
                if (rtTmp.Text.Trim().Length > 0)
                {
                    using (Graphics graphics = Graphics.FromImage(bmpCurrent))
                    {
                        using (Font arialFont = new Font("Arial", rtTmp.Size))
                        {
                            PointF firstLocation = new PointF(rtTmp.X, rtTmp.Y);
                            graphics.DrawString(rtTmp.Text, arialFont, Brushes.Blue, firstLocation);
                            pBoxMain.Image = bmpCurrent;
                        }
                    }
                }
            }
        }

        private bool existRenderText(RenderText rtTmp)
        {
            bool bRet = false;
            foreach(RenderText rt in vRTexts)
            {
                if(rt.Name.ToLower().CompareTo(rtTmp.Name.ToLower()) == 0)
                {
                    bRet = true;
                    break;
                }
            }

            return bRet;
        }

        private void updateRenderTextListInCombo(int iSetTo = -1)
        {
            cboRenderTexts.Items.Clear();
            int iIndx = -1;
            foreach (RenderText rt in vRTexts)
            {
                iIndx++;
                cboRenderTexts.Items.Add(rt.Name);
            }

            if(iSetTo != -1 && iIndx >= iSetTo && iIndx >= 0)
                cboRenderTexts.SelectedIndex = iSetTo;
            else if (iIndx >= 0)
                cboRenderTexts.SelectedIndex = iIndx;
        }

        private void enableControls(bool bEnable = true)
        {            
            btnAddText.Enabled = bEnable;
            btnRender.Enabled = bEnable;
            btnRestart.Enabled = bEnable;
            btnRRender.Enabled = bEnable;
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txtCur = (TextBox)sender;
            if(txtCur.Name == "txtX")
                showPercent(txtX.Text, txtXP, bmpCurrent.Width);
            else if (txtCur.Name == "txtY")
                showPercent(txtY.Text, txtYP, bmpCurrent.Height);

            if (txtCur.Text.Trim().Length > 0)
                saveRenderText();
        }

        private void showPercent(String strTxt, TextBox ctlTxt, int iVal)
        {
            short iTmp;
            int iX = Int16.TryParse(strTxt, out iTmp) ? Int16.Parse(strTxt) : 0;
            float fXP = ((float)iX / (float)iVal) * 100f;
            ctlTxt.Text = fXP.ToString("0.00");
        }
    }
}
