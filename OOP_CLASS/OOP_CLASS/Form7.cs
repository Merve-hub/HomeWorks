using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_CLASS
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Akıllı_Saat akıllıSaat = new Akıllı_Saat();
            akıllıSaat.marka = "Huawei";
            akıllıSaat.renk = "Turuncu";
            akıllıSaat.fiyat = 50m;
            akıllıSaat.kasaCap=25;

            string format = string.Format("Marka: { 0}   Fiyat: { 1} Renk: { 2} Kasa Çap : {3 }", akıllıSaat.marka, akıllıSaat.renk, akıllıSaat.fiyat, akıllıSaat.kasaCap);
            lbxAkıllıSaat.Items.Add(format);


        }
    }
}
