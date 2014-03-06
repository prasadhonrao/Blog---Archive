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
        // Threads share data if they have a common reference to the same object instance

        bool isStarPrinted = false;
       
        static void Main(string[] args)
        {
            var instance = new Program();
            instance.PrintStar();

            new Thread(instance.PrintStar).Start();

            Console.ReadLine();
        }

        void PrintStar()
        {
            if (!isStarPrinted)
            {
                Console.WriteLine(" * ");
                isStarPrinted = true;
            }
        }
    }
}
