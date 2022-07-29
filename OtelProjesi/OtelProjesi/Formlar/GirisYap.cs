using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelProjesi.Formlar
{
    public partial class GirisYap : Form
    {
        Musteri musteri;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1E3PP0A;Initial Catalog=OTEL;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;


        DateTime StartDate = new DateTime(2010, 1, 01);
        DateTime EndDate = new DateTime(2100, 1, 01);

        int DayInterval = 1;

        public GirisYap()
        {
            InitializeComponent();
            this.musteri = new Musteri();
        }

     
        private void lnklUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            this.Hide();
        }


        private void lnklSifreUnutma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreunuttum sifre = new sifreunuttum();
            sifre.Show();
            this.Hide();
        }

  

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string eposta = txbxePosta.Text;
            string sifre = txbxSifre.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            if (rdbtnMusteri.Checked == true)
            {
                cmd.CommandText = "select*from tblMusteri where ePostaAdersi='" + txbxePosta.Text + "'and Sifre='" + txbxSifre.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı");

                    MusteriAnaSayfasi ana = new MusteriAnaSayfasi();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("e-Posta veya Şifre Hatalı!!!");

                }

            }
            else if (rdbtnCalisan.Checked == true)
            {
                cmd.CommandText = "select*from tblCalisan where ePostaAdersi='" + txbxePosta.Text + "'and Sifre='" + txbxSifre.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı");

                    Resepsiyon re = new Resepsiyon();
                    re.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("e-Posta veya Şifre Hatalı!!!");
                }

            }
            else if (rdbtnYonetici.Checked == true)
            {
                cmd.CommandText = "select*from tblCalisan where ePostaAdersi='" + txbxePosta.Text + "'and Sifre='" + txbxSifre.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı");

                    Resepsiyon re = new Resepsiyon();
                    re.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("e-Posta veya Şifre Hatalı!!!");
                }


            }
            else
            {
                MessageBox.Show("Giriş Türü Boş Bırakılamaz!!");
            }
            con.Close();
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            List<DateTime> dateList = new List<DateTime>();
            if (StartDate.AddDays(DayInterval) <= EndDate && (DateTime.Now.Hour.ToString() == "0"))
            {
                StartDate = StartDate.AddDays(DayInterval);
                dateList.Add(StartDate);

                string cumle = "backup database Otel to disk='yedekotel'";
                cmd = new SqlCommand(cumle, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
           // MessageBox.Show("" + DateTime.Now.Minute.ToString());
        }
    }
}
