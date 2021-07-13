using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrallelTasking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coloer = { "1. red", "2. Grean", "3. Blue", "4. White", "5. vilete", "6. Black", "7. Yellow" };
            Console.WriteLine("Using Parallel.For Each");
            var sw = Stopwatch.StartNew();
            Parallel.ForEach(coloer, colers =>
            {
                Console.WriteLine("{0}, Thread Id={1}", colers, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            Console.WriteLine("Parallel ForEach", sw.Elapsed.TotalSeconds);

            Console.WriteLine("Traditional For Each");
            foreach(string colers in coloer)
            {
                Console.WriteLine("{0}, Thread Id={1}", colers, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10); 
            }
            Console.WriteLine("Parallel ForEach", sw.Elapsed.TotalSeconds);
            Console.ReadLine();
        }
    }
}
