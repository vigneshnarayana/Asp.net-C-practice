using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileAdded
{
    class Program
    {
        static void Main(string[] args)
        {
            string authors = "Mahesh Chand#Henry He#Chris Love#Raj Beniwal#Praveen Kumar";
            // Split authors separated by a comma followed by space  
            string[] authorsList = Regex.Split(authors, "#");
            foreach (string author in authorsList){
                Console.WriteLine(author);
            }
            Console.ReadLine();

        }
    }
}
