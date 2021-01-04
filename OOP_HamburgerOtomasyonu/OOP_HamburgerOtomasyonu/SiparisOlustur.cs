using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }


        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            List<Menüler> menüler = new List<Menüler>()
            {
                new Menüler {MenüAdı= "McChicken" ,  MenüFiyatı=15  },
                new Menüler {MenüAdı= "Whopper" ,  MenüFiyatı=20  },
                new Menüler {MenüAdı= "BigKing" ,  MenüFiyatı=18  }
            };

            foreach (Menüler menu in menüler)
                
            {
                cmbMenu.Items.Add(menüler);



            }

            List<Ekstra> ekstra = new List<Ekstra>()
            {

                new Ekstra {EkstraAd = "hardal" ,  EkstraFiyat=1 },
                 new Ekstra {EkstraAd = "Acısos" ,  EkstraFiyat=1 },
                  new Ekstra {EkstraAd = "Barbekü" ,  EkstraFiyat=1 }

            };
            foreach (Ekstra ekstra1  in ekstra)

            {
                flwEkstra.Controls.Add(new CheckBox() { Text = ekstra1.EkstraAd });

            }


           

            List<MenüBoyut> boyut = new List<MenüBoyut>()
            {
                new MenüBoyut{ MenüBoyutt= "orta" },
               new MenüBoyut {MenüBoyutt="Büyük", MenüBoyutFiyat=3},
               new MenüBoyut{MenüBoyutt="King" , MenüBoyutFiyat=5 }

            };


            Siparis siparis = new Siparis();
            if (rbBuyuk.Checked)
            {
                //siparisTutarı += 1;


            }





        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
