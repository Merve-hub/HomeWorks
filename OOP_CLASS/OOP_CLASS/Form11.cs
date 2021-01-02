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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            Yazıcı yazıcı = new Yazıcı();
            yazıcı.fiyat = 50m;
            yazıcı.kategori = "lazer yazıcı";
            yazıcı.marka = "canon";
            yazıcı.MalzemeTıpı = "toner";
            string format = string.Format("Marka : {0}  kategori : {1}  fiyat : {2}  MalzemeTıpi : {3} ", yazıcı.marka, yazıcı.fiyat, yazıcı.kategori, yazıcı.MalzemeTıpı);
            lbxYazıcı.Items.Add(format);

        }
    }
}
