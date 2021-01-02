
namespace OOP_InherıtanceHomework
{
    partial class Form1
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
            this.lbxKitap = new System.Windows.Forms.ListBox();
            this.lbxElektronık = new System.Windows.Forms.ListBox();
            this.lbxMuzik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxKitap
            // 
            this.lbxKitap.FormattingEnabled = true;
            this.lbxKitap.Location = new System.Drawing.Point(0, 2);
            this.lbxKitap.Name = "lbxKitap";
            this.lbxKitap.Size = new System.Drawing.Size(565, 95);
            this.lbxKitap.TabIndex = 0;
            // 
            // lbxElektronık
            // 
            this.lbxElektronık.FormattingEnabled = true;
            this.lbxElektronık.Location = new System.Drawing.Point(0, 103);
            this.lbxElektronık.Name = "lbxElektronık";
            this.lbxElektronık.Size = new System.Drawing.Size(565, 95);
            this.lbxElektronık.TabIndex = 1;
            // 
            // lbxMuzik
            // 
            this.lbxMuzik.FormattingEnabled = true;
            this.lbxMuzik.Location = new System.Drawing.Point(0, 204);
            this.lbxMuzik.Name = "lbxMuzik";
            this.lbxMuzik.Size = new System.Drawing.Size(565, 95);
            this.lbxMuzik.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxMuzik);
            this.Controls.Add(this.lbxElektronık);
            this.Controls.Add(this.lbxKitap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKitap;
        private System.Windows.Forms.ListBox lbxElektronık;
        private System.Windows.Forms.ListBox lbxMuzik;
    }
}

