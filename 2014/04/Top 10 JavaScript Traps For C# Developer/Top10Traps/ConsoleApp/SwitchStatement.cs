using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            var age = Console.ReadLine();

            switch (age)
            {
                case "10":
                    Console.WriteLine("Take Milk");
                    break;
                case "30":
                    Console.WriteLine("Take Beer");
                    break;
                case "50":
                    Console.WriteLine("Take Medicine");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
