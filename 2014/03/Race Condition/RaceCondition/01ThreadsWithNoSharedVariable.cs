using System;
using System.Threading;

namespace RaceCondition
{
    class Program
    {
        // Simple multi threaded program with no shared variable

        static void Main(string[] args)
        {
            // Console.WriteLine("Main Thread Id = {0} \n", Thread.CurrentThread.ManagedThreadId);

            Thread T1 = new Thread(PrintPlus);
            T1.Start();

            Thread T2 = new Thread(PrintMinus);
            T2.Start();

            // PrintMinus();
            Console.ReadLine();
        }

        static void PrintPlus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 100; i++)
            {
                Console.Write(" + ");
            }
        }

        private static void PrintMinus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);
            
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" - ");
            }
        }
    }
}
