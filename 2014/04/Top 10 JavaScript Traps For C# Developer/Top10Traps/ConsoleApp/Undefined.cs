using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Undefined
    {
        static void Main(string[] args)
        {
            WelcomeUser("Prasad");
            WelcomeUser("Colin", "Good Morning");
            // WelcomeUser(); // this won't compile as userName is mandatory parameter
            Console.ReadLine();
        }

        static void WelcomeUser(string userName, string welcomeMessage = "Welcome")
        {
            Console.WriteLine("{0} {1}!", welcomeMessage, userName);
        }
    }
}
