using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        // Simple multi threaded program with no shared varialble

        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Id = {0} \n", Thread.CurrentThread.ManagedThreadId);

            Thread T1 = new Thread(PrintPlus);
            T1.Start();

            PrintMinus();

            Console.ReadLine();
        }

        private static void PrintMinus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);
            
            for (int i = 0; i < 250; i++)
            {
                Console.Write(" - ");
            }
        }

        static void PrintPlus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 250; i++)
            {
                Console.Write(" + ");
            }
        }
    }
}
