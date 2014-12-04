using System;
using System.Console;

namespace LanguageFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor textColor = ForegroundColor;
            try
            {
                ForegroundColor = ConsoleColor.Red;
                Write("Enter your name ");

                ForegroundColor = ConsoleColor.Blue;
                string name = ReadLine();

                ForegroundColor = ConsoleColor.Red;
                WriteLine("Hello {0}, welcome to C# 6.0!", name);

                ReadLine();
            }
            finally
            {
                ForegroundColor = textColor;
            }
        }
    }
}
