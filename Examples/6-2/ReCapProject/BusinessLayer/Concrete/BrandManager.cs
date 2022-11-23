using Business.Constants;
using BusinessLayer.Abstract;
using Core.Utilities;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<Brand> GetByID(int Id)
        {
            return new SuccessDataResult<Brand>(Messages.BrandListed);
        }
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandAddedError);
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAddedSuccess);
            }

        }
        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandUpdatedError);
            }
            else
            {
                _brandDal.Update(brand);
                return new SuccessResult(Messages.BrandUpdatedSuccess);
            }
        }
        public IResult Delete(Brand brand)
        {
            if (brand==null)
            {
                return new ErrorResult(Messages.BrandDeletedError);
            }
            else
            {
                _brandDal.Delete(brand);
                return new SuccessResult(Messages.BrandDeletedSuccess);
            }
        }
    }
}
