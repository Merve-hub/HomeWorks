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
    public partial class Form4 : Form
    {
        public Form4()
        { 
            InitializeComponent();
        }

        private void Cuzdan_Load(object sender, EventArgs e)
        {
        Cuzdan cüzdan = new Cuzdan();
        cüzdan.marka = "Stradivarius";
        cüzdan.boyut = "Küçük";
        cüzdan.renk = "Turuncu";
        cüzdan.materyal = "Deri";
        cüzdan.Fermuarlı = true;
            string format = string.Format("Marka : {0} Boyut: {1} Renk : {2} Materyal : {3} Fermuarlı : {4}  ", cüzdan.marka, cüzdan.boyut, cüzdan.renk, cüzdan.materyal, cüzdan.Fermuarlı);

            lbxCuzdan.Items.Add(format);



        }
    }
}
