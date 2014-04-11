using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ForEach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterating over non generic collection - Array");
            var rainbowColors = new[] {"Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet"};
            foreach (var rainbowColor in rainbowColors)
            {
                Console.WriteLine(rainbowColor);
            }

            Console.WriteLine();

            Console.WriteLine("Iterating over generic collection - List<T>");
            var weekdays = new List<string>(){"Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun"};
            foreach (var weekday in weekdays)
            {
                Console.WriteLine(weekday);
            }

            Console.ReadLine();
        }
    }
}
