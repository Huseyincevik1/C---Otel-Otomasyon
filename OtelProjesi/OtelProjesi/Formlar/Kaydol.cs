using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProjesi.Formlar
{
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

       

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            Musteri musteri = new Musteri();
            
                musteri.musteriAd = textBox2.Text;
                musteri.musteriSoyad = textBox5.Text;
                musteri.Telefon = textBox4.Text;
                musteri.ePostaAdersi = txbxePosta.Text;
                musteri.Adres = textBox1.Text;
                musteri.Sifre = textBox3.Text;
                
                veri.MusteriEkle(musteri);
                MessageBox.Show("Kayıt Başarılı");
            

        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
