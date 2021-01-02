
namespace OOP_CLASS
{
    partial class Form4
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
            this.lbxCuzdan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxCuzdan
            // 
            this.lbxCuzdan.FormattingEnabled = true;
            this.lbxCuzdan.Location = new System.Drawing.Point(22, 26);
            this.lbxCuzdan.Name = "lbxCuzdan";
            this.lbxCuzdan.Size = new System.Drawing.Size(575, 329);
            this.lbxCuzdan.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxCuzdan);
            this.Name = "Form4";
            this.Text = "Cuzdan";
            this.Load += new System.EventHandler(this.Cuzdan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCuzdan;
    }
}