using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Adaptor;

namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new ServiceMernisAdaptor());
            baseCustomerManager.Save(new Customer
            {
                ID = 1,
                CustomerName = "Yunus Emre",
                CustomerLastname = "Kobal",
                DateofBirth = new DateTime(2000, 07, 22),
                NationalID = "17341713490"
            });
            Console.ReadLine();
        }


    }
}
