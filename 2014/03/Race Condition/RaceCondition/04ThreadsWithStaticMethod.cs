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

        static void Main(string[] args)
        {
            new Thread(PrintStar).Start();

            PrintStar();

            Console.ReadLine();
        }

        static void PrintStar()
        {
            if (!isStarPrinted)
            {
                // swap these statements and chances of * printed twice goes up.
                Console.WriteLine(" * ");
                isStarPrinted = true;
            }
        }
    }
}
