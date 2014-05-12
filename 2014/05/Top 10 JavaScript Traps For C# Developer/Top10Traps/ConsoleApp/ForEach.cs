using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ForEach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterating over string array");
            var rainbowColors = new[] { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            foreach (var rainbowColor in rainbowColors)
            {
                Console.WriteLine(rainbowColor);
            }

            Console.WriteLine();

            Console.WriteLine("Iterating over specialized collection - StringCollection");
            var cities = new StringCollection { "Pune", "London", "New York", "Mumbai" };
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();

            Console.WriteLine("Iterating over generic collection - List<T>");
            var weekdays = new List<string>() { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };
            foreach (var weekday in weekdays)
            {
                Console.WriteLine(weekday);
            }

            Console.ReadLine();
        }
    }
}
