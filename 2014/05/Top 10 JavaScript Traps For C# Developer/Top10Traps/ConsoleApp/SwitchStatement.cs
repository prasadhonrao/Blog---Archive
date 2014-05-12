using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SwitchStatement
    {
        static void Main()
        {
            Console.WriteLine("Enter your age");
            var age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 10:
                    Console.WriteLine("Drink milk");
                    break;
                case 20:
                case 30:
                    Console.WriteLine("Take Latte or beer");
                    break;
                case 50 - 10:
                    Console.WriteLine("You can have Whiskey");
                    break;
                case 50:
                    Console.WriteLine("Take medicine");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
