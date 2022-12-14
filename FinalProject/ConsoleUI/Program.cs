using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();

            //ProductTest();
            ProductListTest();
        }

        private static void ProductListTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal));
            {
                var result = productManager.GetAll();
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
            
        }
        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var item in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(item.ProductName + "/" + item.CategoryName);
                }                
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
