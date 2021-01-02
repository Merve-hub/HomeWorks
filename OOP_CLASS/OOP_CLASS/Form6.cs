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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Sarj sarj = new Sarj();
            sarj.marka = "samsung";
            sarj.fiyat = 50m;
            sarj.renk = "turuncu";

            string format = string.Format("Marka : {0}  Fiyat : {1}  Renk : {2} ", sarj.marka, sarj.fiyat, sarj.renk);
            lbxSarj.Items.Add(format);


        }
    }
}
