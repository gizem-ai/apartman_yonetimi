using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace _201613709028
{
    class CreateJsonProgram
    {
        public static string jsonresult;
        public static void CreateJson(int kisisayisi, List<Sakinler> DaireSakinleriListesi, string baslik)
        {
            //BinaSakinler binaSakinleri = new BinaSakinler();
            BinaSakinler.sakinler = new List<Sakinler> { };
            for (int i = 0; i < kisisayisi; i++)
            {
                BinaSakinler.sakinler.Add(DaireSakinleriListesi[i]);
                /*try
                {
                }
                catch (ArgumentOutOfRangeException)
                {
                    DialogResult result1 = MessageBox.Show("Uygulamayı kapatmaya emin misin?",
                            "Uygulama Çıkış", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        //this.Close();
                    }
                    else
                    {
                        //No ise yapmasını istediğiniz...
                    }
                    //MessageBox.Show("Eksik giriş yaptınız. Yeni giriş yapmak için Geri butonuna basın, devam etmek için Onayla butonuna basın.");
                    break;
                    //linke bak evet hayır butonu koy
                }*/
            }
            jsonresult = JsonConvert.SerializeObject(BinaSakinler.sakinler);
            FileWriterProgram.FileWriter(jsonresult, baslik);
        }
    }
}
