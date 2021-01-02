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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Aksiyon_Kamerası kamera = new Aksiyon_Kamerası();
            kamera.fiyat = 50m;
            kamera.marka = "samsung";
            kamera.renk = "turuncu";

            string format = string.Format("Marka : {0}  Fiyat : {1}  Renk : {2} ", kamera.fiyat, kamera.marka, kamera.renk);
            lbxaksıyon.Items.Add(format);


        }
    }
}
