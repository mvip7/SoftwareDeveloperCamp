using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers = new Customers();

            customers.CustomerID = 1;
            customers.CustomerName = "Yunus Emre";
            customers.CustomerLastName = "Kobal";
            customers.City = "Bursa";
            customers.CustomerSalary = 6000;

            Customers customers2 = new Customers();
            customers2.CustomerID = 2;
            customers2.CustomerName = "Mustafa";
            customers2.CustomerLastName = "Dengi";
            customers2.City = "Adana";
            customers2.CustomerSalary = 6300;

            Customers customers3 = new Customers();
            customers3.CustomerID = 3;
            customers3.CustomerName = "Buse";
            customers3.CustomerLastName = "Konmaz";
            customers3.City = "Kırsehir";
            customers3.CustomerSalary = 5900;

            Customers customers4 = new Customers();
            customers4.CustomerID = 4;
            customers4.CustomerName = "Derin";
            customers4.CustomerLastName = "Aydin";
            customers4.City = "Istanbul";
            customers4.CustomerSalary = 8600;

            Customers[] customersArrays = new Customers[] { customers, customers2, customers3, customers4 };

            CustomersManager customersManager = new CustomersManager();

            customersManager.Add(customers);
            customersManager.Add(customers2);
            customersManager.Add(customers3);
            customersManager.Add(customers4);
            Console.WriteLine("////////////");
            customersManager.Delete(customers3);
            Console.WriteLine("////////////");
            customersManager.List(customersArrays);



        }
    }
}
