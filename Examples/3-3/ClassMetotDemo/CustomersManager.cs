using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
     class CustomersManager
    {
        public void Add(Customers customers)
        {
            Console.WriteLine(customers.CustomerName + " " + customers.CustomerLastName + " İsimli Müşteri Eklendi.");
        }
        public void Update(Customers customers)
        {
            Console.WriteLine(customers.CustomerName + " " + customers.CustomerLastName + " İsimli Müşteri Güncellendi.");
        }
        public void Delete(Customers customers)
        {
            Console.WriteLine(customers.CustomerName + " " + customers.CustomerLastName + " Müşteri Silindi.");
        }
        public void List(Customers[] customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item.CustomerID.ToString() + " " + item.CustomerName + " " + item.CustomerLastName + " " + item.City + " " + item.CustomerSalary.ToString()); ;
            }
        }

    }
}
