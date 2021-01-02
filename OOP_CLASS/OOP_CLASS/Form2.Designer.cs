
namespace OOP_CLASS
{
    partial class Form2
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
            this.lbxListe = new System.Windows.Forms.ListBox();
            this.grbKordon = new System.Windows.Forms.GroupBox();
            this.cbSilikon = new System.Windows.Forms.CheckBox();
            this.cbDeri = new System.Windows.Forms.CheckBox();
            this.cbCelik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.grbSekil = new System.Windows.Forms.GroupBox();
            this.cbOval = new System.Windows.Forms.CheckBox();
            this.cbKare = new System.Windows.Forms.CheckBox();
            this.cbDortgen = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grbKordon.SuspendLayout();
            this.grbSekil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxListe
            // 
            this.lbxListe.FormattingEnabled = true;
            this.lbxListe.Location = new System.Drawing.Point(474, 16);
            this.lbxListe.Name = "lbxListe";
            this.lbxListe.Size = new System.Drawing.Size(275, 316);
            this.lbxListe.TabIndex = 14;
            // 
            // grbKordon
            // 
            this.grbKordon.Controls.Add(this.cbSilikon);
            this.grbKordon.Controls.Add(this.cbDeri);
            this.grbKordon.Controls.Add(this.cbCelik);
            this.grbKordon.Location = new System.Drawing.Point(12, 115);
            this.grbKordon.Name = "grbKordon";
            this.grbKordon.Size = new System.Drawing.Size(200, 100);
            this.grbKordon.TabIndex = 11;
            this.grbKordon.TabStop = false;
            this.grbKordon.Text = "Kordon Materyali";
            // 
            // cbSilikon
            // 
            this.cbSilikon.AutoSize = true;
            this.cbSilikon.Location = new System.Drawing.Point(7, 55);
            this.cbSilikon.Name = "cbSilikon";
            this.cbSilikon.Size = new System.Drawing.Size(57, 17);
            this.cbSilikon.TabIndex = 2;
            this.cbSilikon.Text = "Silikon";
            this.cbSilikon.UseVisualStyleBackColor = true;
            // 
            // cbDeri
            // 
            this.cbDeri.AutoSize = true;
            this.cbDeri.Location = new System.Drawing.Point(74, 19);
            this.cbDeri.Name = "cbDeri";
            this.cbDeri.Size = new System.Drawing.Size(45, 17);
            this.cbDeri.TabIndex = 1;
            this.cbDeri.Text = "Deri";
            this.cbDeri.UseVisualStyleBackColor = true;
            // 
            // cbCelik
            // 
            this.cbCelik.AutoSize = true;
            this.cbCelik.Location = new System.Drawing.Point(7, 20);
            this.cbCelik.Name = "cbCelik";
            this.cbCelik.Size = new System.Drawing.Size(49, 17);
            this.cbCelik.TabIndex = 0;
            this.cbCelik.Text = "Çelik";
            this.cbCelik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marka";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(104, 27);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 7;
            // 
            // grbSekil
            // 
            this.grbSekil.Controls.Add(this.cbOval);
            this.grbSekil.Controls.Add(this.cbKare);
            this.grbSekil.Controls.Add(this.cbDortgen);
            this.grbSekil.Location = new System.Drawing.Point(255, 115);
            this.grbSekil.Name = "grbSekil";
            this.grbSekil.Size = new System.Drawing.Size(160, 100);
            this.grbSekil.TabIndex = 12;
            this.grbSekil.TabStop = false;
            this.grbSekil.Text = "Kordon Şekli";
            // 
            // cbOval
            // 
            this.cbOval.AutoSize = true;
            this.cbOval.Location = new System.Drawing.Point(7, 55);
            this.cbOval.Name = "cbOval";
            this.cbOval.Size = new System.Drawing.Size(48, 17);
            this.cbOval.TabIndex = 2;
            this.cbOval.Text = "Oval";
            this.cbOval.UseVisualStyleBackColor = true;
            // 
            // cbKare
            // 
            this.cbKare.AutoSize = true;
            this.cbKare.Location = new System.Drawing.Point(91, 19);
            this.cbKare.Name = "cbKare";
            this.cbKare.Size = new System.Drawing.Size(48, 17);
            this.cbKare.TabIndex = 1;
            this.cbKare.Text = "Kare";
            this.cbKare.UseVisualStyleBackColor = true;
            // 
            // cbDortgen
            // 
            this.cbDortgen.AutoSize = true;
            this.cbDortgen.Location = new System.Drawing.Point(7, 20);
            this.cbDortgen.Name = "cbDortgen";
            this.cbDortgen.Size = new System.Drawing.Size(78, 17);
            this.cbDortgen.TabIndex = 0;
            this.cbDortgen.Text = "Dikdörtgen";
            this.cbDortgen.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(181, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxListe);
            this.Controls.Add(this.grbKordon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.grbSekil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form2";
            this.Text = "Dikdörtgen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbKordon.ResumeLayout(false);
            this.grbKordon.PerformLayout();
            this.grbSekil.ResumeLayout(false);
            this.grbSekil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxListe;
        private System.Windows.Forms.GroupBox grbKordon;
        private System.Windows.Forms.CheckBox cbSilikon;
        private System.Windows.Forms.CheckBox cbDeri;
        private System.Windows.Forms.CheckBox cbCelik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.GroupBox grbSekil;
        private System.Windows.Forms.CheckBox cbOval;
        private System.Windows.Forms.CheckBox cbKare;
        private System.Windows.Forms.CheckBox cbDortgen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}