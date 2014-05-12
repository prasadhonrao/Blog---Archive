using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Hoisting
    {
        static void Main(string[] args)
        {
            int? someVariable = null;
            Console.WriteLine(someVariable); //undefined

            someVariable = 42; //Global variable
            Console.WriteLine(someVariable); // 42

            DoSomething();
        }

        private static void DoSomething()
        {
            int? someVariable = null;
            Console.WriteLine(someVariable); //undefined

            someVariable = 1;
            Console.WriteLine(someVariable); // 1
        }
    }
    
}

