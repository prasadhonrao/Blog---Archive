using System;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        // Simple multi threaded program implemented using TPL

        static void Main(string[] args)
        {
            Task.Factory.StartNew(PrintPlus);
            Task.Factory.StartNew(PrintMinus);
            
            //PrintMinus();
            Console.ReadLine();
        }

        static void PrintPlus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 50; i++)
            {
                Console.Write(" + ");
                Console.Write("\t");
            }
        }
        private static void PrintMinus()
        {
            // Console.WriteLine("Thread Id = {0}", Thread.CurrentThread.ManagedThreadId);
            
            for (int i = 0; i < 50; i++)
            {
                Console.Write(" - ");
                Console.Write("\t");
            }
        }
    }
}
