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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string[] kategoriler = { "Kolye", "Küpe", "Bileklik", "Yüzük" };

        

        private void Form1_Load(object sender, EventArgs e)
        {

            Takı takı = new Takı();

            takı.kategori = "kolye";
            takı.cesit = "Altın";
            takı.tasCinsi = "pırlanta";
            takı.beden = "XS";

            string format = string.Format("Kategori:  {0} Çeşit:  {1} TaşCinsi:  {2} Beden:  {3}", takı.kategori,takı.cesit,takı.tasCinsi,takı.beden);

            listBox1.Items.Add(format);

        }

        
        //string secim = string.Empty;


        //private void Form1_Load(object sender, EventArgs e)
        //{

        //    foreach (string kategori in kategoriler)
        //    {
        //        cmbTakı.Items.Add(kategori);

        //    }


        //}


        //private void btnEkle_Click(object sender, EventArgs e)

        //{


        //    if (rbAltın.Checked)
        //    {
        //        secim += (rbAltın.Text + " /");
        //    }
        //    else if (rbGümüş.Checked)
        //    {
        //        secim += (rbGümüş.Text + " /");
        //    }

        //    foreach (CheckBox chk in grbCins.Controls)

        //        if (chk.Checked)
        //        {


        //            secim += chk.Text + " /";

        //        }

        //    foreach (CheckBox chk in groupBox1.Controls)

        //        if (chk.Checked)
        //        {

        //            secim += chk.Text + "  ";

        //        }



        //    secim += cmbTakı.Text + "   ...";

        //    listBox1.Items.Add(secim);







        //    DialogResult result = MessageBox.Show("Seçimlerinizi Silmek istemisiniz", "İşlemi tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //    if (result == DialogResult.Yes)
        //    {
        //        Temizle();
        //    }


        //}


        //void Temizle()

        //{
        //    string secim = string.Empty;
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl is ComboBox)
        //        {
        //            ComboBox cmb = (ComboBox)ctrl;
        //            cmb.SelectedIndex = -1;
        //        }
        //        else if (ctrl is RadioButton)
        //        {
        //            RadioButton rb = (RadioButton)ctrl;
        //            rb.Checked = false;

        //        }
        //        else if (ctrl is GroupBox)
        //        {
        //            foreach (CheckBox chk in ctrl.Controls)
        //            {
        //                chk.Checked = false;
        //            }
        //        }

        //        else if (ctrl is ListBox)
        //        {
        //            ListBox lst = (ListBox)ctrl;
        //            lst.Items.Clear();
        //        }
        //    }
        //}

    }
}
