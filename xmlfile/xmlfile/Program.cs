using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace xmlfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            //string responseFromServer = ????.GetStringFromUrl("http://www.example.com/test.xml");
            using (WebClient client = new WebClient())
            {
                 s = client.DownloadString("http://cbimages.cbazaar.com/Logistics/FedEx/Shipment/Response/6170501455_FileUploadResponse.txt");
                   
            }
            //List<string> file = s.ToList();
             s.GetType();
            
            
            //foreach (String a in file)
            //{
            //    Console.WriteLine(a);

            //}
            Console.WriteLine(s);



            //Regex.Split(s, @"/SUCCESS/").Count()
            //Regex r = new Regex(@"^\<HighestSeverity>SUCCESS</HighestSeverity>\");
            ////class Regex Repesents an immutable regular expression.  
            //r.IsMatch(s);

            Console.ReadLine();
        }



    }
}
