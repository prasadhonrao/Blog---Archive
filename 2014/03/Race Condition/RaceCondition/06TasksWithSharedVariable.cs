using System;
using System.Threading.Tasks;

namespace RaceCondition
{
    class _06TasksWithSharedVariable
    {
        // Simple multi threaded program with shared variable

        private static int counter;

        static void Main(string[] args)
        {
            Task.Factory.StartNew(PrintPlus);
            Task.Factory.StartNew(PrintMinus);

            // PrintMinus();
            Console.ReadLine();
        }

        static void PrintPlus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (counter = 0; counter < 100; counter++)
            {
                Console.Write(" + ");
            }
        }

        private static void PrintMinus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (counter = 0; counter < 100; counter++)
            {
                Console.Write(" - ");
            }
        }
    }
}
