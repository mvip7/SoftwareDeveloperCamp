﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car,CarRentalContext>,ICarDal
    {
        
    }
}
