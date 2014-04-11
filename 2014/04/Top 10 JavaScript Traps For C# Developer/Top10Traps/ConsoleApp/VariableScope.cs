using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VariableScope
    {
        private static string message = "Class level variable";
        static void Main(string[] args)
        {
            message = "Override message";
            Console.WriteLine(message);

            if (1 > 0)
            {
                var newMessage = "This is a new message";
                Console.WriteLine(newMessage);
            }

            Console.ReadLine();
        }
    }
}
