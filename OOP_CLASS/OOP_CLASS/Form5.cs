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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            PowerBank power = new PowerBank();
            power.marka = "samsung ";
            power.Renk = "turuncu";
            power.pilGucu = 20000;
            power.kablo = "USB";
            string format = string.Format("Marka : {0} Renk:{1}  Pilgucu : {2} Kablo:  {3}", power.marka, power.Renk, power.pilGucu, power.kablo);
            lbxPowerBank.Items.Add(format);


        }
    }
}
