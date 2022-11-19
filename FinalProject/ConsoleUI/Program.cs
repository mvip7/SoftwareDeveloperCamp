using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName+" - "+item.UnitPrice.ToString());
            }
            Console.WriteLine("\n/////\n");
            foreach (var item in productManager.GetAllByCategoryID(4))
            {
                Console.WriteLine(item.ProductName+" "+item.UnitPrice);
            }
            Console.WriteLine("\n/////\n");
            
            foreach (var item in productManager.GetByUnitPrice(10,50))
            {
                Console.WriteLine(item.ProductName + " " + item.UnitPrice);
            }
        }
    }
}
