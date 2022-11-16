using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICarManager
    {
        List<Car> GetAll();
        List<Car> GetById();
        void Add(Car car);
        void Update(Car car);
        void Delete(int ID);
    }
}
