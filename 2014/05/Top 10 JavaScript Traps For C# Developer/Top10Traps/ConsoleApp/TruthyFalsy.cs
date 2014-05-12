using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TruthyFalsy
    {
        static void Main(string[] args)
        {
            var firstNumber = 10;
            var secondNumber = "10";

            // Below statements will result into compile time error
            if (firstNumber == secondNumber) { }
            while (1) { }
            while (0) { }

            // Converting number to string and then typecast to bool
            var equalNumber = ((bool)(firstNumber.ToString() == secondNumber));
            Console.WriteLine(equalNumber);
            Console.ReadLine();

            while (true)
            {
                Console.WriteLine("In True");
            }

            
        }
    }
}
