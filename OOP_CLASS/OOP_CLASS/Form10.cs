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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Klavye klavye = new Klavye();
            klavye.fiyat = 50m;
            klavye.FKlavye = true;
            klavye.marka = "samsung";
            klavye.baglantı = "bluetooth";
            string format = string.Format("Marka : {0}  Fiyat : {1} Bağlantı : {2}", klavye.marka, klavye.fiyat, klavye.baglantı);
            lbxKlavye.Items.Add(format);
        }
    }
}
