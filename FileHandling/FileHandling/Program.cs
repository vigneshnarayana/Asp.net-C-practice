using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] files = System.IO.Directory.GetFiles(@"C:\Users\vignesh.n\Desktop\New folder\", "*.txt");
           
            //var datas = files.Count();
            //foreach(var i in files)
            //{
            //    if (Directory.Exists(i))
            //    {

            //    }
            //    var data = i;
            //}
            ////String filePath = @"C:\Users\vignesh.n\Desktop\New folder\6170501455_FileUploadResponse";
            ////String[] lines = File.ReadAllLines(filePath);


            //List<String> file = new List<string>();
            //file = File.ReadAllLines(filePath).ToList();
            //foreach (String a in file)
            //{
            //   int counts = Regex.Split(a, @"<HighestSeverity>SUCCESS").Count();

            //}

            //file.Add("Demo Adding Data");
            //File.WriteAllLines(filePath, file);
            //Console.ReadLine();


            StreamWriter sw;
            string Filename = @"E:\dataFileCheck.txt";
            sw = File.CreateText(Filename);
            string Filedata = "demo checking";
            sw.WriteLine(Filedata);
            sw.Close();
        }
    }
}
