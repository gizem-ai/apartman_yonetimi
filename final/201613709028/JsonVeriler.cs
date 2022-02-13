using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201613709028
{
    public class JsonVeriler
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string DaireNo { get; set; }
        public string Odeme_turu { get; set; }
        public int Tutar { get; set; }
        public string Tarih { get; set; }

        public JsonVeriler(string isim, string soyisim, string daireno, string odeme_turu, string tutar, string tarih)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.DaireNo = daireno;
            this.Odeme_turu = odeme_turu;
            this.Tutar = Convert.ToInt32(tutar);
            this.Tarih = tarih;
        }
    }
}
