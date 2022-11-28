using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, Name = "Yunus", Age = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }

        [ToTable("Customers")]
        [ToTable("TblCustomers")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string Name { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            public int Age { get; set; }
        }


        class CustomerDal
        {
            public void Add(Customer customer)
            {
                Console.WriteLine("{0}-{1}-{2}-{3} Added !!!", customer.Id, customer.Name, customer.LastName, customer.Age);
            }
        }

        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
        class RequiredProperty : Attribute
        {

        }

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        class ToTable : Attribute
        {
            string _tableName;
            public ToTable(string tableName)
            {
                _tableName = tableName;
            }
        }
    }
}
