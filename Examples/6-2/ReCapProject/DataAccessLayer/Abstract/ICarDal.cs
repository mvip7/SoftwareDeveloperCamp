using Core.DataAccess;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal:IEntityRepos<Car>
    {
        List<CarInfoDto> GetCarInfo();
    }
}
