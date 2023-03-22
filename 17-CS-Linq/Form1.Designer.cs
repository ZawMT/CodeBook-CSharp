
namespace _17_CS_Linq
{
    partial class Form1
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
            this.btnSort = new System.Windows.Forms.Button();
            this.txtTrace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(724, 253);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(112, 34);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtTrace
            // 
            this.txtTrace.Location = new System.Drawing.Point(12, 12);
            this.txtTrace.Multiline = true;
            this.txtTrace.Name = "txtTrace";
            this.txtTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrace.Size = new System.Drawing.Size(678, 275);
            this.txtTrace.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 299);
            this.Controls.Add(this.txtTrace);
            this.Controls.Add(this.btnSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtTrace;
    }
}

