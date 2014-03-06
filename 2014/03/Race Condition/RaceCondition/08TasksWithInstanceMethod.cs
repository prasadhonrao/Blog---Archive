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
        // Tasks share data if they have a common reference to the same object instance

        bool isStarPrinted = false;
       
        static void Main(string[] args)
        {
            var instance = new Program();
            instance.PrintStar();

            Task.Factory.StartNew(instance.PrintStar);

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
