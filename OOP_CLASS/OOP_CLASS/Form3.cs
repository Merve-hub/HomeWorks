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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Gözlük gözlük = new Gözlük();
            gözlük.marka = "Osse";
            gözlük.camTipi = "Aynalı";
            gözlük.cerceveForm = "Oval";

            string format = string.Format("Marka:{0} Camtipi:{1}  ÇerçeveForm :{2} ", gözlük.marka, gözlük.camTipi, gözlük.cerceveForm);
            listBox1.Items.Add(format);

        }
    }
}
