
namespace OOP_CLASS
{
    partial class Form7
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
            this.lbxAkıllıSaat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxAkıllıSaat
            // 
            this.lbxAkıllıSaat.FormattingEnabled = true;
            this.lbxAkıllıSaat.Location = new System.Drawing.Point(12, 12);
            this.lbxAkıllıSaat.Name = "lbxAkıllıSaat";
            this.lbxAkıllıSaat.Size = new System.Drawing.Size(398, 407);
            this.lbxAkıllıSaat.TabIndex = 0;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxAkıllıSaat);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAkıllıSaat;
    }
}