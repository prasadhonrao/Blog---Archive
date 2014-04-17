using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VariableScope
    {
        private static string favoriteCity = "London";
        static void Main()
        {
            Console.WriteLine("Your favorite city is {0}", favoriteCity);
            favoriteCity = "New York";
            PrintFavoriteCity(favoriteCity);

            if (favoriteCity.Equals("New York"))
            {
                var welcomeMessage = "Welcome New Yorker";
                Console.WriteLine(welcomeMessage);
            }

            Console.ReadLine();
        }

        static void PrintFavoriteCity()
        {
            Console.WriteLine("Your favorite city is {0}", favoriteCity);
        }
    }
}
