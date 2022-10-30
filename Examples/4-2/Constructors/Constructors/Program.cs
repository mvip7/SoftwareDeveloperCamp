using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(3, "Yunus", "Kobal", "Bursa");
            
            Customer customer2 = new Customer(4, "Buse", "Konmaz", "Antalya");
            Customer customer3 = new Customer();
            customer3.CustomerID = 3;
            Console.WriteLine(customer3.CustomerID);
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        // Default Constructor Metod çalıştırıldıgında otomatik çalışan metot
        public Customer(int id,string customerName,string customerLastname,string city)
        {
            CustomerID = id;
            CustomerName = customerName;
            CustomerLastname = customerLastname;
            City = city;
        }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
        public string City { get; set; }
    }
}
