using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201613709028
{
    class CreatJsonGider
    {
        public static string jsunResultGider;
        public static void CreateJsonG(int giderveri, List<JsonVerilerG> jsonVerilerGs, string baslik)
        {
            jsunResultGider = JsonConvert.SerializeObject(kasaListGider.jsonVerilerGs);
            FileWriterProgram.FileWriter(jsunResultGider, baslik);
        }
    }
}
