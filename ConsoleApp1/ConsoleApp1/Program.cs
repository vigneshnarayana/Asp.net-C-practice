using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static string soapBody;
        private static object nodeName;

        static void Main(string[] args)
        {
            XNamespace soapNameSpace
            = XNamespace.Get("http://cbimages.cbazaar.com/Logistics/FedEx/Shipment/Response/786045923131_FileUploadResponse.txt");
            var document = XDocument.Parse(soapBody);

            var soapMessage = document?.Root?.Descendants()?.Where(p =>
                        p.Name.LocalName.Equals(nodeName) && p.Name.Namespace
                        == soapNameSpace).FirstOrDefault()?.ToString();

            soapMessage = soapMessage?.Replace("xmlns:urn=", "xmlns=")
                                              .Replace("<urn:", "<")
                                              .Replace("</urn:", "</");
            Console.WriteLine(soapMessage);
          
        }
    }
}
