using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductID = 1;
            product.CategoryID =2;
            product.ProductName = "Buzdolabı";
            product.UnitPrice = 4800;
            product.UnitStocks = 98;

            ProductService productService = new ProductService();
            productService.Add(product);
            Console.WriteLine(product.ProductName);

            ProductService productService1 = new ProductService();

            int sonu = productService.Topla(2, 6);


        }
    }
}
