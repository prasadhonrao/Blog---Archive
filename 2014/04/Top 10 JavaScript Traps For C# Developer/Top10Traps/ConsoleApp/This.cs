using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class This
    {
        static void Main(string[] args)
        {
            var emp = new Employee(1, "Prasad");
            emp.PrintEmployee();
            Console.WriteLine(emp.PrintNameAndLength());
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("ID : {0} , Name : {1}", this.Id, this.Name);
        }
    }

    public static class EmployeeExtension
    {
        public static string PrintNameAndLength(this Employee emp)
        {
            return emp.Name + " : " + emp.Name.Length;
        }
    }
}
