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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Canta canta = new Canta();
            canta.fiyat = 50m;
            canta.boyut = "orta";
            canta.marka = "pull&bear";
            canta.materyal = "deri";
            canta.renk = "turuncu";

            string format = string.Format("Marka : {0}  Fiyat : {1}  Renk : {2}  Materyal : {3} Boyut  : {4} ", canta.renk, canta.materyal, canta.marka, canta.boyut,canta.fiyat);
            lbxCanta.Items.Add(format);


         }
    }
}
