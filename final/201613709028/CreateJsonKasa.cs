using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201613709028
{
    class CreateJsonKasa
    {
        public static string jsonResult;
        public static void CreateJsonK(int veriSayisi, List<JsonVeriler> jsonVerilers, string baslik)
        {
            jsonResult = JsonConvert.SerializeObject(kasaList.jsonVerilerL);
            FileWriterProgram.FileWriter(jsonResult, baslik);
        }
    }
}
