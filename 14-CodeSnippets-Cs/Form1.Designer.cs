
namespace _14_CodeSnippets_Cs
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
            this.btnStripEdge = new System.Windows.Forms.Button();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStripEdge
            // 
            this.btnStripEdge.Location = new System.Drawing.Point(590, 133);
            this.btnStripEdge.Name = "btnStripEdge";
            this.btnStripEdge.Size = new System.Drawing.Size(198, 34);
            this.btnStripEdge.TabIndex = 0;
            this.btnStripEdge.Text = "Test Strip Edge";
            this.btnStripEdge.UseVisualStyleBackColor = true;
            this.btnStripEdge.Click += new System.EventHandler(this.btnStripEdge_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 12);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(776, 31);
            this.txtInput1.TabIndex = 1;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(12, 51);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(776, 31);
            this.txtInput2.TabIndex = 2;
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(12, 92);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(776, 31);
            this.txtInput3.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.btnStripEdge);
            this.Name = "frmMain";
            this.Text = "C# Code Snippets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStripEdge;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput3;
    }
}
