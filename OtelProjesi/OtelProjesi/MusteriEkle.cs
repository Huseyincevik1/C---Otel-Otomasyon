using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;


namespace OtelProjesi
{
    public class MusteriEkle
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Eposta { get; set; }
        public DateTime GirisT { get; set; }
        public DateTime CikisT { get; set; }
        public int OdaNo { get; set; }
        public string KartNo { get; set; }


        

        public void Ekle()
        {

            sqlConnection con = new sqlConnection(@"Data Source=DESKTOP-1E3PP0A;Initial Catalog=OTEL;Integrated Security=True");


            SqlCommand c = new SqlCommand(" exec sp_MusteriEkle ");
            
            con.Open();
            c.Parameters.AddWithValue("@musteriAd", Ad);
            c.Parameters.AddWithValue("@musteriSoyad", Soyad);
            c.Parameters.AddWithValue("@TCkimlikNO", TcNo);
            c.Parameters.AddWithValue("@ePostaAdersi", Eposta);
            c.Parameters.AddWithValue("@gelisTarih", GirisT);
            c.Parameters.AddWithValue("@gidisTarih", CikisT);
            c.Parameters.AddWithValue("@odaNO", OdaNo);
            c.Parameters.AddWithValue("@kartNO", KartNo);

            c.ExecuteNonQuery();
            con.Close();
        }
      
    }
}
