
namespace OOP_CLASS
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxYazıcı = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxYazıcı
            // 
            this.lbxYazıcı.FormattingEnabled = true;
            this.lbxYazıcı.Location = new System.Drawing.Point(-1, 12);
            this.lbxYazıcı.Name = "lbxYazıcı";
            this.lbxYazıcı.Size = new System.Drawing.Size(547, 394);
            this.lbxYazıcı.TabIndex = 0;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxYazıcı);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxYazıcı;
    }
}