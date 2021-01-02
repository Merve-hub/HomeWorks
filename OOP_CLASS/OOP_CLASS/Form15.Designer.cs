
namespace OOP_CLASS
{
    partial class Form15
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
            this.lbxKulaklık = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxKulaklık
            // 
            this.lbxKulaklık.FormattingEnabled = true;
            this.lbxKulaklık.Location = new System.Drawing.Point(2, 12);
            this.lbxKulaklık.Name = "lbxKulaklık";
            this.lbxKulaklık.Size = new System.Drawing.Size(684, 446);
            this.lbxKulaklık.TabIndex = 1;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxKulaklık);
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKulaklık;
    }
}