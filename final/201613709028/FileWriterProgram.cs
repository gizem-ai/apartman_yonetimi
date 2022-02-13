using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _201613709028
{
    class FileWriterProgram
    {
        public static string path = Path.GetFullPath("jsonVerileri");
        //public static string path;
        public static void FileWriter(string jsonresult, string Baslik)
        {
            
            path = path + "\\" + Baslik + ".json"; //proje dosyasının 
            //string path = @"C:\Users\gizem\Desktop\nesne\final\201613709028\verilerJson\" + Baslik + ".json";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(jsonresult.ToString());
                    //tw.Close();
                }
            }

            path = Path.GetFullPath("jsonVerileri");

        }
    }
}
