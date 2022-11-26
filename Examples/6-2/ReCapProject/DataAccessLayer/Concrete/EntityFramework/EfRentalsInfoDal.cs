﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRentalsInfoDal: EfEntityRepositoryBase<RentalsInfo, CarRentalContext>, IRentalsInfoDal
    {
    }
}
