using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category {CategoryID=1,CategoryName="Beyaz Eşya"},
                new Category {CategoryID=2,CategoryName="Elektronik"},
                new Category {CategoryID=3,CategoryName="Kıyafet"},
            };
            List<Product> products = new List<Product>
            {
                new Product {ProductID=1,CategoryID=2,ProductName="Tıraş Makinesi",QuantityPerUnit="-",UnitPrice=180,UnitsInStock=152},
                new Product {ProductID=2,CategoryID=2,ProductName="Tablet",QuantityPerUnit="32 GB",UnitPrice=1200,UnitsInStock=120},
                new Product {ProductID=3,CategoryID=3,ProductName="Takım Elbise",QuantityPerUnit="-",UnitPrice=650,UnitsInStock=200},
                new Product {ProductID=4,CategoryID=1,ProductName="Fırın",QuantityPerUnit="-",UnitPrice=800,UnitsInStock=175},
                new Product {ProductID=5,CategoryID=3,ProductName="Gömlek",QuantityPerUnit="-",UnitPrice=80,UnitsInStock=80}
            };
            Console.Write("LINQ OLMADAN-------\n\n");
            foreach (var item in products)
            {
                if (item.UnitPrice > 500 && item.UnitsInStock < 150)
                {
                    Console.WriteLine(item.ProductName);
                }
            }


            Console.Write("\nLINQ -------\n\n");
            var result = products.Where(p => p.UnitPrice < 500 && p.UnitsInStock < 200);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }


            static List<Product> GetProducts(List<Product> products)
            {

                List<Product> filteredProducts = new List<Product>();
                foreach (var item in products)
                {
                    if (item.UnitPrice > 500 && item.UnitsInStock < 150)
                    {
                        filteredProducts.Add(item);
                    }
                }
                return filteredProducts;
            }

            static List<Product> GetProductsLinq(List<Product> products)
            {
                return products.Where(p => p.UnitPrice < 500 && p.UnitsInStock < 200).ToList();
            }
            GetProducts(products);
            GetProductsLinq(products);
        }


        class Product
        {
            public int ProductID { get; set; }
            public int CategoryID { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }

        }
        class Category
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
