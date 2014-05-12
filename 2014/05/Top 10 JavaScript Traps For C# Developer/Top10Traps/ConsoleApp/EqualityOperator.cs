using System;

namespace ConsoleApp
{
    class EqualityOperator
    {
        static void Main()
        {
            // Value Type
            Console.WriteLine("10 == 10 ? " + (10 == 10)); // returns true
            Console.WriteLine("10 != 10 ? " + (10 != 10)); // returns false.
            Console.WriteLine("10 != 20 ? " + (10 != 20)); // returns true. 

            // Reference Type
            var emp1 = new Employee();
            var emp2 = new Employee();
            Console.WriteLine("emp1 == emp2 ? " + (emp1 == emp2)); // returns false

            emp1 = emp2;
            Console.WriteLine("emp1 == emp2 ? " + (emp1 == emp2));


            // Strings
            Console.WriteLine("A == B ? " + ("A" == "B"));
            var temp = string.Copy("A");
            Console.WriteLine("A == A ? " + ("A" == temp));

            Console.ReadLine();
        }
    }

    class Employee
    {
    }
}
