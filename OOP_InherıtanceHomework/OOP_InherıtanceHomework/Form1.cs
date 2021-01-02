using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_InherıtanceHomework
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YabancıAlbum album = new YabancıAlbum();
            album.Sanatci = "Ariana Grande";
            album.MedyaTip = "CD";
            album.Fiyat = 84;

            Tablet tablet = new Tablet();
            tablet.Marka = "vestel";
            tablet.fiyat = 50m;
            tablet.Renk = "turuncu";
            tablet.bellek = 16;
            tablet.ısletımSıstemı = "android";

            Kitap kitap = new Kitap();
            kitap.YazarAdi = "Grigory Petrov";
            kitap.YayinEvi = " İndigo Kitap";
            kitap.Fiyat = 22;
            kitap.CevirmenAdı = "Burak Cemil Yılmaz";
            kitap.kitapTürü = "roman";


            Kitap ktp = new Kitap();
            ktp.YazarAdi = " Yuval Noah Harari";
            ktp.YayinEvi = " kolektif kitap";
            ktp.Fiyat = 33;
            ktp.CevirmenAdı = "Ertuğrul Genç";
            ktp.kitapTürü = "tarih";


            Kitap book = new Kitap();
            book.YazarAdi = " Sinan Canan";
            book.YayinEvi = " TutiKitap";
            book.kitapTürü = "bilim";

            List<Urun> urunListesi = new List<Urun>();
            urunListesi.Add(kitap);
            urunListesi.Add(tablet);
           urunListesi.Add(album);
           
            foreach (Urun urun in urunListesi)
            {
                if (urun is Kitap)
                {
                    Kitap kit = (Kitap)urun;
                   lbxKitap.Items.Add(kit.YazarAdi);

                }
                else if (urun is Elektronik)
                {
                    Elektronik elk = (Elektronik)urun;
                    lbxElektronık.Items.Add(elk.Marka);
                }
                else if (urun is Müzik)
                {
                    Müzik müz = (Müzik)urun;
                    lbxMuzik.Items.Add(müz.Sanatci);
                }
            }






        }
    }
}
