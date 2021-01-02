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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            Kulaklık kulaklık = new Kulaklık();
            kulaklık.fiyat = 50m;
            kulaklık.marka = "samsung";
            kulaklık.renk = "turuncu";
            string format = string.Format("Marka : {0}  renk : {1}  fiyat : {2} ", kulaklık.marka, kulaklık.renk, kulaklık.fiyat);
            lbxKulaklık.Items.Add(format);
        }
    }
}
