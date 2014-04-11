using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ReturnStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 20));

            Console.WriteLine(DefaultEmployee().Name);
            Console.ReadLine();

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static Employee DefaultEmployee()
        {
            return new Employee
                    {
                        Id = 1,
                        Name = "Default"
                    };
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
