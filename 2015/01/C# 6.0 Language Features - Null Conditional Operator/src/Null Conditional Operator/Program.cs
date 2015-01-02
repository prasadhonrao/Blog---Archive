using System;
using System.Collections.Generic;

namespace Null_Conditional_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = Program.GetSampleCustomerData();
            foreach (var cust in customers)
            {
                // Console.WriteLine(string.Format("Name : {0} \t Address : {1}", cust.Name, cust.Address.City));

                //if (cust.Address != null)
                //{
                //    Console.WriteLine("Name : {0} \t Address : {1}", cust.Name, cust.Address.City);
                //}
                //else
                //{
                //    Console.WriteLine("Name : {0} \t Address : {1}", cust.Name, string.Empty);
                //}

                Console.WriteLine("Name : {0} \t Address : {1}", cust.Name, cust.Address?.City);

            }
        }
        public static List<Customer> GetSampleCustomerData()
        {
            return new List<Customer>
            {
                new Customer { Name ="Craig Daniel" ,  Address = new Address { Street ="Green Hollow Dr", City = "Iselin", ZipCode = "NJ4648"} },
                new Customer { Name ="Scott Hanselman" },
                new Customer { Name ="John Papa" },
                new Customer { Name ="Prasad Honrao", Address = new Address { Street ="Dorset Street",  City = "Glasgow", ZipCode ="G12345" } },
                new Customer { Name ="Dan Wahlin" },
                new Customer { Name ="Albert Pinto",  Address = new Address { City = "New York", Street ="Main Street", ZipCode = "AB1010"} }
            };
        }
    }
    
    public class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
