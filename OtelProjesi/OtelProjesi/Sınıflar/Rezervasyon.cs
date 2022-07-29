using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProjesi
{
    class Rezervasyon
    {
        public int rezervasyonID { get; set; }
        public DateTime rezervasyonTarih { get; set; }
        public bool iptalMi { get; set; }
        public DateTime ertelemeTarih { get; set; }
        public decimal tabanFiyat { get; set; }
        public decimal kalmaFiyat { get; set; }
        public DateTime gelisTarih { get; set; }
        public DateTime gidisTarih { get; set; }
        public int odaNO { get; set; }
        public int musteriID { get; set; }
        public int rezervasyonTipiID { get; set; }
    }
}
