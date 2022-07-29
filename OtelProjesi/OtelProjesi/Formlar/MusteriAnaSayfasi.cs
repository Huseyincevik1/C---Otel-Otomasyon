using System;
using System.Windows.Forms;

namespace OtelProjesi.Formlar
{
    public partial class MusteriAnaSayfasi : Form
    {
        Musteri musteri;

      

        public MusteriAnaSayfasi(Musteri musteri)
        {
            InitializeComponent();
            this.musteri = musteri;
        }
        public MusteriAnaSayfasi()
        {

        }


        private void MusteriAnaSayfasi_Load(object sender, EventArgs e)
        {

            labelAD.Text = $"{musteri.musteriAd} {musteri.musteriSoyad}";

        }

    }
}
