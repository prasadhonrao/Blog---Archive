using System.Console;

namespace Auto_Property_Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldCustomer = new Customer("Mumbai");
            var newCustomer = new CustomerV2();
            WriteLine(oldCustomer.City);
            WriteLine(newCustomer.City);
            ReadLine();
        }
    }

    public class Customer
    {
        public string City { get; private set; }

        public Customer(string city)
        {
            this.City = city;
        }
    }

    public class CustomerV2
    {
        public string City { get; } = "London";
    }
}
