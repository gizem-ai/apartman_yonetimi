using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201613709028
{
    class giderJsonUstuneEkleme
    {
        private static string giderTuru;
        private static string tutar;
        private static string tarih;
        private static JsonVerilerG veriler;
        public static void giderinUstuneEkleme()
        {
            if (System.IO.File.Exists(FileWriterProgram.path + "\\Gider.json"))
            {
                string jsoNGider = System.IO.File.ReadAllText(FileWriterProgram.path + "\\Gider.json");
                int deneme = JArray.Parse(jsoNGider).Count();
                for (int i = 0; i < deneme; i++)
                {
                    giderTuru = JArray.Parse(jsoNGider).Children()["GiderTuru"].ElementAt(i).ToString();
                    tutar = JArray.Parse(jsoNGider).Children()["Tutar"].ElementAt(i).ToString();
                    tarih = JArray.Parse(jsoNGider).Children()["Tarih"].ElementAt(i).ToString();
                    veriler = new JsonVerilerG(giderTuru, tutar, tarih);
                    kasaListGider.ListeEkle(veriler);
                }
            }
        }
    }
}
