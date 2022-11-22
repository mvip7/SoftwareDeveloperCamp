using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarInfoDto> GetCarInfo()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorID equals color.Id
                             join brand in context.Brands on car.BrandID equals brand.Id
                             select new CarInfoDto
                             {
                                 CarId=car.ID,
                                 Color=color.ColorName,
                                 Brand=brand.BrandName,
                                 DailyPrice=car.DailyPrice
                             };
                return result.ToList();
                // tekrar söylermisin 
            }
        }
       // Emin Değilim

    }
}
