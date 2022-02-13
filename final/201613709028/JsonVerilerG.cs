using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201613709028
{
    public class JsonVerilerG
    {
        public string GiderTuru { get; set; }
        public int Tutar { get; set; }
        public string Tarih { get; set; }

        public JsonVerilerG(string GiderTuru, string Tutar, string Tarih)
        {
            this.GiderTuru = GiderTuru;
            this.Tutar = Convert.ToInt32(Tutar);
            this.Tarih = Tarih;
        }

    }
}
