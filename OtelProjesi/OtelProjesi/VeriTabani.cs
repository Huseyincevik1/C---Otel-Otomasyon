using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProjesi
{
    class VeriTabani
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataTable tablo = new DataTable();
      
        public VeriTabani()
        {
          con=  new SqlConnection("Data Source=.;Initial Catalog=OTEL;Integrated Security=True");
        }

        public SqlConnection baglanti()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=OTEL;Integrated Security=True");
            con.Open();
            return baglanti();
        }
        public void MusteriEkle(Musteri m)
        {


            cmd = new SqlCommand("sp_MusteriEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@musteriAd", m.musteriAd);
            cmd.Parameters.AddWithValue("@musteriSoyad", m.musteriSoyad);
            cmd.Parameters.AddWithValue("@Telefon", m.Telefon);
            cmd.Parameters.AddWithValue("@ePostaAdersi", m.ePostaAdersi);
            cmd.Parameters.AddWithValue("@Adres", m.Adres);
            cmd.Parameters.AddWithValue("@Sifre", m.Sifre);



            int a =cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RezervasyonEkle(Rezervasyon r)
        {
            cmd = new SqlCommand("sp_RezervasyonEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@rezervasyonTarih",r.rezervasyonTarih);
            cmd.Parameters.AddWithValue("@musteriID",r.musteriID);
            cmd.Parameters.AddWithValue("@gelisTarih", r.gelisTarih);
            cmd.Parameters.AddWithValue("@gidisTarih", r.gidisTarih);
            cmd.Parameters.AddWithValue("@rezervasyonTipiID",r.rezervasyonTipiID);
           
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void FaturaBilgisi()
        {
            adtr = new SqlDataAdapter("sp_faturabilgisi", con);
            adtr.Fill(tablo);
            
            
        }

     
     
    }
}
