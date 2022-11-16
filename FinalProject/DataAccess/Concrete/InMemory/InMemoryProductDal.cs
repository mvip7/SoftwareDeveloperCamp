using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductID=1,CategoryID=1,ProductName="Bardak",UnitPrice=10,UnitsInStock=200},
                new Product {ProductID=2,CategoryID=3,ProductName="Kamera",UnitPrice=680,UnitsInStock=220},
                new Product {ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=3500,UnitsInStock=150},
                new Product {ProductID=4,CategoryID=2,ProductName="Tablet",UnitPrice=1200,UnitsInStock=100}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;
            //// LINQ OLMADAN YAPILAN SILME İŞLEMİ
            //foreach (var p  in _products)
            //{
            //    /* Listedeki Tüm elemanları dolaşıp, dışarıdan gelen product nesnesindeki
            //        elemanın productID'si ile foreach döngüsünde tanımladıgımız p elamanının
            //        productID'si eşit ise productToDelete nesnesine p nesnesini tutturuyoruz
            //     */
            //    if (product.ProductID==p.ProductID)
            //    {
            //        productToDelete = p;
            //    }
            //}            

            //// LINQ İLE SİLME İŞLEMİ
            ///
            // SingleOrDefault foreach döngüsünün kısayolu gibi tek bir eleman tutar
            productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p=>p.CategoryID==CategoryId).ToList();
        }

        public void Update(Product product)
        {
            // Dışarıdan Gelen Product'taki productID'ye sahip ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryID = product.CategoryID;        
        }
    }
}
