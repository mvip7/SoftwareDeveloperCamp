using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            GetAllByCategoryID(6);
        }

        private static void GetAllByCategoryID(int categoryID)
        {
            NorthwindContext context = new NorthwindContext();
            var result = context.Products.Where(p => p.CategoryID == categoryID);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();

            foreach (var item in context.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
