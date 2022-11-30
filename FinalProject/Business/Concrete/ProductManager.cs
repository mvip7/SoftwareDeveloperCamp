using Business.Abstract;
using System.Linq;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Business;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            // Business Codes => Kullanıcı tarafından alınan doğru veriler sonucunda, kullanıcının belirtilen kriterlere uyup
            // uymadığını kontrol edeceğimiz kısımdır

            // Validation Code => Kullancı tarafından alınan Verinin uzunluğu,içerdiği karakterler(özel,sayısal,metinsel)
            // gibi kuralların tanımlandığı kısımdır. Veri bütünlüğü ile ilgili yapılan kısıtlamaların yazıldığı kodlar.

           IResult result =  BusinessRules.Run(
                CheckIfCategoryProductCountOfCategoryCorrect(product.CategoryID),
                CheckIfProductNameExists(product.ProductName),
                CheckIfCategoryCount());

            if (result != null)
            {
                return result;
            }
            else
            {
                _productDal.Add(product);
                return new SuccessResult();
            }           
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == id), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 00)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryID(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryID == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>
                (
                _productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min
                ));
        }
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
            }
        }

        private IResult CheckIfCategoryProductCountOfCategoryCorrect(int categoryId)
        {
            var catId = _productDal.GetAll(p => p.CategoryID == categoryId);
            if (catId.Count >= 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }
        private IResult CheckIfProductNameExists(string name)
        {
            var productName = _productDal.GetAll(p => p.ProductName == name).Any();

            if (productName)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }

            return new SuccessResult();
        }
        private IResult CheckIfCategoryCount()
        {
            var catNums = _categoryService.GetAll();
            if (catNums.Data.Count>=15)
            {
                return new ErrorResult();
            }
            return new SuccessResult();                    
        }
    }
}
