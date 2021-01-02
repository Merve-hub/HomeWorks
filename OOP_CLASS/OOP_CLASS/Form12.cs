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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            Monıtor monıtor = new Monıtor();
            monıtor.marka = "Samsung";
            monıtor.renk = "turuncu";
            monıtor.fiyat = 50m;
            string format = string.Format("Marka : {0}  renk : {1}  fiyat : {2} ", monıtor.marka, monıtor.fiyat, monıtor.renk);
            lbxMonıtor.Items.Add(format);

        }
    }
}
