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
using System.Data.Sql;
using System.Net;
using System.Net.Mail;

namespace OtelProjesi.Formlar
{
    public partial class sifreunuttum : Form
    {
        public sifreunuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabani vb = new VeriTabani();
            SqlCommand cmd = new SqlCommand("select*from tblMusteri where KullaniciAdi='" + textBox1.Text.ToString() + "'and ePostaAdersi='" + textBox2.Text.ToString() + "'",vb.baglanti());

            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (vb.baglanti().State == ConnectionState.Closed)
                    {
                        vb.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToString();
                    string mailadres = ("atakanb@gmail.com");
                    string sifre = ("balbal10");
                    string smtpservr = ("smtp.gmail.com");
                    string kime = (oku["ePostaAdersi"].ToString());
                    string konu = ("Şifre Hatırlatma Maili");
                    string yazi = ("Sayın" + oku["musteriAd"].ToString() + oku["musteriSoyad"].ToString() + "\n" + tarih + "tarihinde şifre hatırlatma talebinde bulundunuz" + "\n" + "Şifreniz:" + oku["Sifre"].ToString() + "\n İyi Ginler");
                    smtpserver.Credentials = new NetworkCredential(mailadres, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpservr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadres);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yazi;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Şifreniz Mail Adresinize gönderilmiştir");
                    this.Hide();
                        
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("Hata Oluştu!", Hata.Message);
                    throw;
                }
            }
            
            
        }
    }
}
