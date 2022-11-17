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
                new Product {ProductID=7,CategoryID=3,ProductName="Takım Elbise",QuantityPerUnit="-",UnitPrice=650,UnitsInStock=200},
                new Product {ProductID=5,CategoryID=1,ProductName="Buzdolabı",QuantityPerUnit="-",UnitPrice=2300,UnitsInStock=175},
                new Product {ProductID=4,CategoryID=3,ProductName="Gömlek",QuantityPerUnit="-",UnitPrice=80,UnitsInStock=80},
                new Product {ProductID=11,CategoryID=3,ProductName="Mont",QuantityPerUnit="-",UnitPrice=650,UnitsInStock=80}
            };

            Product newProducts = new Product { ProductID = 21, CategoryID = 1, ProductName = "Davlumbaz", QuantityPerUnit = "-", UnitPrice = 1250, UnitsInStock = 145 };

            products.Add(newProducts);

            // -- Single Line Query --

            //    Test(products);
            //    AnyTest(products);
            //    FindMethod(products);
            //    AscDescTest(products);

            // -- Other Method --
            //ClassicLinqTest(products);

            // -- Join İşlemi -- İki Tablonun belirlenen kritere göre birleştirilmesi

            var result = from p in products
                         join c in categories
      on p.CategoryID equals c.CategoryID
                         where p.ProductID.ToString().EndsWith("1")
                         select new ProductDto { ProductID = p.ProductID, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };
            foreach (var item in result)
            {
                Console.WriteLine("{0} -- {1}", item.ProductName, item.CategoryName);
            }

            var result1 = products.Where(p => p.ProductName.Contains("m") || p.ProductName.Contains("c"));
            foreach (var item in result1)
            {
                item.ProductName.Replace("m", "*");
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("\n-----\n");

            var result2 = from u in products
                          orderby u.CategoryID descending
                          group u by u.CategoryID into urunler
                          select new { Kategori=urunler.Key, Urun=urunler.Count() };
            foreach (var item in result2)
            {
                Console.WriteLine("{0} Kategorisinde {1} Adet Urun Var",item.Kategori,item.Urun);
            }


            //GetProducts(products);
            //GetProductsLinq(products);
            //static List<Product> GetProducts(List<Product> products)
            //{

            //    List<Product> filteredProducts = new List<Product>();
            //    foreach (var item in products)
            //    {
            //        if (item.UnitPrice > 500 && item.UnitsInStock < 150)
            //        {
            //            filteredProducts.Add(item);
            //        }
            //    }
            //    return filteredProducts;
            //}

            //static List<Product> GetProductsLinq(List<Product> products)
            //{
            //    return products.Where(p => p.UnitPrice < 500 && p.UnitsInStock < 200).ToList();
            //}

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitsInStock < 150 && p.ProductName.Length > 5
                         select new ProductDto { ProductID = p.ProductID, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
            var result = products.Where(p => p.ProductName.Contains("m", stringComparison)).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName + " - " + item.UnitPrice);
            }
        }

        private static void FindMethod(List<Product> products)
        {
            var result = products.Find(p => p.ProductID == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Fırın");

            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
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
        }


        class ProductDto
        {
            public int ProductID { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
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
