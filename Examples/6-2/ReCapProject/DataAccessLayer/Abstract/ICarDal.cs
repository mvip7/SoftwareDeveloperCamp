using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICarDal
    {
        List<Car> GetByID();
        List<Car> GetAll();
        void Add(Car cars);
        void Update(Car cars);
        void Delete(int ID);
    }
}
