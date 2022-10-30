using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerID = 1;
            customer1.CustomerIdentityNumber = "2";
            customer1.CustomerName = "Yunus Emre";
            customer1.CustomerLastname = "Kobal";
            customer1.CustomerNo = "4";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);


            
            
        }
    }
}
