using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş Kodları yazıldıktan sonra
            // Yetki Varmı, Kriteri Karşılıyor mu ? gibi operasyonlar

            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int ID)
        {
            return _productDal.GetAll(p=>p.CategoryID==ID);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            var result = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);            
            return result;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
