
namespace _13_CS_Encryption
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.btnEnc = new System.Windows.Forms.Button();
            this.txtEnc = new System.Windows.Forms.TextBox();
            this.btnMd5 = new System.Windows.Forms.Button();
            this.btnEnc2 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(26, 30);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(142, 31);
            this.txtSrc.TabIndex = 0;
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(174, 28);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(134, 34);
            this.btnEnc.TabIndex = 1;
            this.btnEnc.Text = "Sha256 =>";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // txtEnc
            // 
            this.txtEnc.Location = new System.Drawing.Point(26, 68);
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(864, 31);
            this.txtEnc.TabIndex = 2;
            // 
            // btnMd5
            // 
            this.btnMd5.Location = new System.Drawing.Point(314, 27);
            this.btnMd5.Name = "btnMd5";
            this.btnMd5.Size = new System.Drawing.Size(134, 34);
            this.btnMd5.TabIndex = 3;
            this.btnMd5.Text = "MD5 =>";
            this.btnMd5.UseVisualStyleBackColor = true;
            this.btnMd5.Click += new System.EventHandler(this.btnMd5_Click);
            // 
            // btnEnc2
            // 
            this.btnEnc2.Location = new System.Drawing.Point(599, 27);
            this.btnEnc2.Name = "btnEnc2";
            this.btnEnc2.Size = new System.Drawing.Size(152, 35);
            this.btnEnc2.TabIndex = 4;
            this.btnEnc2.Text = "Encrypt";
            this.btnEnc2.UseVisualStyleBackColor = true;
            this.btnEnc2.Click += new System.EventHandler(this.btnEnc2_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(757, 27);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(133, 35);
            this.btnDec.TabIndex = 5;
            this.btnDec.Text = "Decrypt";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 126);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc2);
            this.Controls.Add(this.btnMd5);
            this.Controls.Add(this.txtEnc);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.txtSrc);
            this.Name = "frmMain";
            this.Text = "Encryption Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.TextBox txtEnc;
        private System.Windows.Forms.Button btnMd5;
        private System.Windows.Forms.Button btnEnc2;
        private System.Windows.Forms.Button btnDec;
    }
}
