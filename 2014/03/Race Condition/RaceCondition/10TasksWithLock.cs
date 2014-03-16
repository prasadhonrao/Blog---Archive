using System;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Task T1 = Task.Factory.StartNew(PrintPlus);
            Task T2 = T1.ContinueWith(antacedent => PrintMinus());

            Task.WaitAll(new Task[] { T1, T2 });

            Console.WriteLine("Ending main thread");

            Console.ReadLine();
        }

        static void PrintPlus()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write(" + ");
                Console.Write("\t");
            }
        }

        static void PrintMinus()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write(" - ");
                Console.Write("\t");
            }

        }
    }
}
