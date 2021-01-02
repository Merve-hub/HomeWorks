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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Saat saat = new Saat();
            saat.marka = "Fossil";
            saat.renk = "Mor";
            saat.kadranSekli = "Kare";
            saat.kordonMateyali = "Deri";
             string format = string.Format("Marka :{0} Renk :{1} KadranSekli:{2} KordonMateryali:{3}", saat.marka, saat.renk, saat.kadranSekli, saat.kordonMateyali);
            lbxListe.Items.Add(format);

           

        }
        //string[] markalar= { "Fossil", "Timberland", "Romanson", "Ball" };

        //string secim;

        //private void btnEkle_Click(object sender, EventArgs e)
        //{//}

        //private void Form2_Load(object sender, EventArgs e)
        //{
        //    foreach (string marka in markalar)
        //    {
        //        cmbMarka.Items.Add(marka);
        //    }
        //    secim += markalar + "  ";

        //}


    }
}
