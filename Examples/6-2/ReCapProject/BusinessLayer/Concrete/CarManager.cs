using Business.Constants;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules.FluentValidator;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAddedSuccess);
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.CarDeletedSuccess);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Car> GetById(int Id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ID == Id), Messages.CarListed);
        }

        public IDataResult<List<CarInfoDto>> GetCarInfo(int id)
        {
            return new SuccessDataResult<List<CarInfoDto>>(_carDal.GetCarInfo(id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandID == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorID == id));
        }

        public IResult Update(Car car)
        {
            if (car.Description.Length < 2)
            {
                return new ErrorResult(Messages.CarUpdatedError);
            }
            else
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdatedSuccess);
            }

        }
    }
}
