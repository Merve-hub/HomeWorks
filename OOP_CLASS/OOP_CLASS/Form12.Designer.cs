﻿
namespace OOP_CLASS
{
    partial class Form12
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
            this.lbxMonıtor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxMonıtor
            // 
            this.lbxMonıtor.FormattingEnabled = true;
            this.lbxMonıtor.Location = new System.Drawing.Point(12, 12);
            this.lbxMonıtor.Name = "lbxMonıtor";
            this.lbxMonıtor.Size = new System.Drawing.Size(597, 420);
            this.lbxMonıtor.TabIndex = 0;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxMonıtor);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMonıtor;
    }
}