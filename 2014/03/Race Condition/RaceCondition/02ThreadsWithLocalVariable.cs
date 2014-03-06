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
        // Multiple threads accessing local variable
       
        static void Main(string[] args)
        {
            new Thread(PrintStar);

            PrintStar();

            Console.ReadLine();
        }

        static void PrintStar()
        {
            for (int i = 0; i < 10; i++) // i varibale gets created on two different thread stack
            {
                Console.WriteLine(i + " * ");
            }
        }
    }
}
