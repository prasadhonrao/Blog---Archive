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
        // Multiple threads accessing shared variable using static method

        static bool isStarPrinted = false;
        static object locker = new object();

        static void Main(string[] args)
        {
            new Thread(PrintStar).Start();

            PrintStar();

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
