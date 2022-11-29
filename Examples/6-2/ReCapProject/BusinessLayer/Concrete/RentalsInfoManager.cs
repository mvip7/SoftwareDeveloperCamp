using Business.Constants;
using BusinessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class RentalsInfoManager : IRentalsInfoService
    {
        IRentalsInfoDal _rentalDal;

        public RentalsInfoManager(IRentalsInfoDal ınfoDal)
        {
            _rentalDal = ınfoDal;
        }

        public IResult Add(RentalsInfo rentalsInfo)
        {
            if (rentalsInfo.ReturnDate==null)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            else
            {
                _rentalDal.Add(rentalsInfo);
                return new SuccessResult(Messages.RentalAdded);
            }
        }

        public IResult Delete(RentalsInfo rentalsInfo)
        {
            _rentalDal.Delete(rentalsInfo);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<RentalsInfo>> GetAll()
        {
            return new SuccessDataResult<List<RentalsInfo>>(_rentalDal.GetAll());
        }

        public IResult Update(RentalsInfo rentalsInfo)
        {
            _rentalDal.Update(rentalsInfo);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
