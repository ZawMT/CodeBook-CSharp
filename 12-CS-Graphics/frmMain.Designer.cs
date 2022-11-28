
namespace _12_CS_Graphics
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
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pBoxMain = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.cboRenderTexts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtYP = new System.Windows.Forms.TextBox();
            this.txtXP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRRender = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1246, 684);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBoxMain);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 698);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // pBoxMain
            // 
            this.pBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxMain.Location = new System.Drawing.Point(3, 27);
            this.pBoxMain.Name = "pBoxMain";
            this.pBoxMain.Size = new System.Drawing.Size(1037, 668);
            this.pBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxMain.TabIndex = 0;
            this.pBoxMain.TabStop = false;
            this.pBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxMain_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1078, 684);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(162, 34);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(1246, 380);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(155, 34);
            this.btnRender.TabIndex = 3;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(1375, 68);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(32, 34);
            this.btnAddText.TabIndex = 4;
            this.btnAddText.Text = "+";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // cboRenderTexts
            // 
            this.cboRenderTexts.FormattingEnabled = true;
            this.cboRenderTexts.Location = new System.Drawing.Point(1117, 69);
            this.cboRenderTexts.Name = "cboRenderTexts";
            this.cboRenderTexts.Size = new System.Drawing.Size(252, 33);
            this.cboRenderTexts.TabIndex = 5;
            this.cboRenderTexts.SelectedIndexChanged += new System.EventHandler(this.cboRenderTexts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1117, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1268, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1117, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1089, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Text";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(1163, 174);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(83, 31);
            this.txtX.TabIndex = 10;
            this.txtX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(1297, 173);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(84, 31);
            this.txtY.TabIndex = 11;
            this.txtY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(1164, 222);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(93, 31);
            this.txtSize.TabIndex = 12;
            this.txtSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(1145, 125);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(218, 31);
            this.txtText.TabIndex = 13;
            this.txtText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(1078, 380);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(162, 34);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtYP
            // 
            this.txtYP.Location = new System.Drawing.Point(1296, 272);
            this.txtYP.Name = "txtYP";
            this.txtYP.ReadOnly = true;
            this.txtYP.Size = new System.Drawing.Size(84, 31);
            this.txtYP.TabIndex = 20;
            // 
            // txtXP
            // 
            this.txtXP.Location = new System.Drawing.Point(1162, 273);
            this.txtXP.Name = "txtXP";
            this.txtXP.ReadOnly = true;
            this.txtXP.Size = new System.Drawing.Size(83, 31);
            this.txtXP.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1246, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Y (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1114, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "X (%)";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1078, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 34);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRRender
            // 
            this.btnRRender.Location = new System.Drawing.Point(1078, 420);
            this.btnRRender.Name = "btnRRender";
            this.btnRRender.Size = new System.Drawing.Size(323, 34);
            this.btnRRender.TabIndex = 22;
            this.btnRRender.Text = "Restart n Render All";
            this.btnRRender.UseVisualStyleBackColor = true;
            this.btnRRender.Click += new System.EventHandler(this.btnRRender_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 745);
            this.ControlBox = false;
            this.Controls.Add(this.btnRRender);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtYP);
            this.Controls.Add(this.txtXP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRenderTexts);
            this.Controls.Add(this.btnAddText);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Label image";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pBoxMain;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.ComboBox cboRenderTexts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtYP;
        private System.Windows.Forms.TextBox txtXP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRRender;
    }
}
