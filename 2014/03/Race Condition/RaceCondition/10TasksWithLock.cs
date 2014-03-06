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
        // Multiple task accessing shared variable using static method

        static bool isStarPrinted = false;
        static object locker = new object();

        static void Main(string[] args)
        {
            Task.Factory.StartNew(PrintStar);

            Task.Factory.StartNew(PrintStar);

            Console.ReadLine();
        }

        static void PrintStar()
        {
            lock (locker) // Thread safe code
            {
                if (!isStarPrinted)
                {
                    Console.WriteLine(" * ");
                    isStarPrinted = true;
                }
            }
        }
    }
}
