using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FunctionOverload
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 + 20 = " + Add(10,20));
            Console.WriteLine("10 + 20 + 30 = " + Add(10, 20, 30));
            Console.ReadLine();
        }

        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
    }
}
