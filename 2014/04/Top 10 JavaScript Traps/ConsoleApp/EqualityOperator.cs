using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class EqualityOperator
    {
        static void Main(string[] args)
        {
            #region Equality
            var firstNumber = 10;
            var secondNumber = 10;
            var thirdNumber = 20;
            var equalNumbers = firstNumber == secondNumber;
            var notEqualNumbers = firstNumber != thirdNumber;
            Console.WriteLine("10 == 10 ? " + equalNumbers);
            Console.WriteLine("10 != 20 ? " + notEqualNumbers);

            var firstString = "Hello";
            var secondString = "World";
            var equalStrings = firstString == secondString;
            Console.WriteLine("Hello == World ? " + equalStrings);

            var thirdString = string.Copy(firstString);
            equalStrings = firstString == thirdString;
            Console.WriteLine("Hello == Hello ? " + equalStrings);

            var emp1 = new Employee();
            var emp2 = new Employee();
            var sameEmployee = emp1 == emp2;
            Console.WriteLine("emp1 == emp2 ? " + sameEmployee);

            emp1 = emp2;
            sameEmployee = emp1 == emp2;
            Console.WriteLine("emp1 == emp2 ? " + sameEmployee); 
            #endregion

            Console.ReadLine();
        }
    }
}
