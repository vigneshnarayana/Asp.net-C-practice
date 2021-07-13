using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Treading
{
     public class ThreadWorker
    {
        int Id;
        Thread t;
        public ThreadWorker(int id)
        {
            this.Id = id;
            t = new Thread(new ThreadStart(dowork));
            t.Start();
        }
        void dowork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Running" + Id);
            }
            Console.WriteLine("Thread Id Is Finish" + Id);
        }
    }
    class Program
    {  

        //static void dowork()
        //{
        //    for(int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Thread Running" + i);
        //    }
        //}
        static void Main(string[] args)
        {
            //Thread t = new Thread(new ThreadStart(dowork));
            //t.Start();
            for (int i = 0; i < 10; i++)
            {
                ThreadWorker tr = new ThreadWorker(i);
            }
            Console.ReadLine();
        }
    }
}
