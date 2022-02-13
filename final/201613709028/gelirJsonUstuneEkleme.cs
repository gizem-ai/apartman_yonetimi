using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201613709028
{
    class gelirJsonUstuneEkleme
    {
        private static string Isim;
        private static string Soyisim;
        private static string DaireNo;
        private static string Odeme_turu;
        private static string Tutar;
        private static string Tarih;
        private static JsonVeriler veriler;
        public static void gelirinUstuneEkleme()
        {
            if (System.IO.File.Exists(FileWriterProgram.path + "\\Gelir.json"))
            {
                string jsoNGelir = System.IO.File.ReadAllText(FileWriterProgram.path + "\\Gelir.json");
                int deneme = JArray.Parse(jsoNGelir).Count();
                for (int i = 0; i < deneme; i++)
                {
                    Isim = JArray.Parse(jsoNGelir).Children()["Isim"].ElementAt(i).ToString();
                    Soyisim = JArray.Parse(jsoNGelir).Children()["Soyisim"].ElementAt(i).ToString();
                    DaireNo = JArray.Parse(jsoNGelir).Children()["DaireNo"].ElementAt(i).ToString();
                    Odeme_turu = JArray.Parse(jsoNGelir).Children()["Odeme_turu"].ElementAt(i).ToString();
                    Tutar = JArray.Parse(jsoNGelir).Children()["Tutar"].ElementAt(i).ToString();
                    Tarih = JArray.Parse(jsoNGelir).Children()["Tarih"].ElementAt(i).ToString();
                    veriler = new JsonVeriler(Isim, Soyisim, DaireNo, Odeme_turu, Tutar, Tarih);
                    kasaList.ListeEkle(veriler);
                }
            }
        }
    }
}
