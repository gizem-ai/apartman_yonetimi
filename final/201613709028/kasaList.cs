using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201613709028
{
    class kasaList
    {
        //gelirlistesi
        public static List<JsonVeriler> jsonVerilerL { get; set; }
        private static int sayac = 0;
        public static void ListeEkle(JsonVeriler veri)
        {
            sayac = sayac + 1;
            if(sayac == 1)
            {
                jsonVerilerL = new List<JsonVeriler> { };
                jsonVerilerL.Add(veri);
            }
            else
            {
                jsonVerilerL.Add(veri);
            }
            
        }
        
    }
}
