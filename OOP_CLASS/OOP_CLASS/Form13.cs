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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            Tablet tablet = new Tablet();
            tablet.marka = "samsung";
            tablet.fiyat = 50m;
            tablet.renk = "turuncu";
            tablet.kapasite = 16m;
            string format = string.Format("Marka : {0}  kategori : {1}  fiyat : {2} Kapasite  : {3}", tablet.marka,tablet.fiyat, tablet.renk,
            tablet.kapasite);
            lbxtablet.Items.Add(format);

        }
    }
}
