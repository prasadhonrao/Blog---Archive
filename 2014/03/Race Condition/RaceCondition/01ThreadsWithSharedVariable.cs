using System;
using System.Threading;

namespace RaceCondition
{
    class _01ThreadsWithSharedVariable
    {
        // Simple multi threaded program with no shared variable

        private static int counter;

        static void Main(string[] args)
        {
            // Console.WriteLine("Main Thread Id = {0} \n", Thread.CurrentThread.ManagedThreadId);

            var T1 = new Thread(PrintPlus);
            T1.Start();

            var T2 = new Thread(PrintMinus);
            T2.Start();

            // PrintMinus();
            Console.ReadLine();
        }

        static void PrintPlus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (counter = 0; counter < 50; counter++)
            {
                Console.Write(" + ");
                Console.Write("\t");
            }
        }

        private static void PrintMinus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (counter = 0; counter < 50; counter++)
            {
                Console.Write(" - ");
                Console.Write("\t");
            }
        }
    }
}
