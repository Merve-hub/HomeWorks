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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            Mouse mouse = new Mouse();
            mouse.marka = "samsung";
            mouse.fiyat = 50m;
            mouse.renk = "turunucu";
            string format = string.Format("Marka : {0}  Renk : {1}  fiyat : {2}", mouse.marka, mouse.fiyat, mouse.renk);
            lbxMouse.Items.Add(format);

        }
    }
}
