using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201613709028
{
    class kasaListGider
    {
        public static List<JsonVerilerG> jsonVerilerGs { get; set; }

        private static int sayac = 0;
        public static void ListeEkle(JsonVerilerG veri)
        {
            sayac = sayac + 1;
            if (sayac == 1)
            {
                jsonVerilerGs = new List<JsonVerilerG> { };
                jsonVerilerGs.Add(veri);
            }
            else
            {
                jsonVerilerGs.Add(veri);
            }

        }
    }
}
