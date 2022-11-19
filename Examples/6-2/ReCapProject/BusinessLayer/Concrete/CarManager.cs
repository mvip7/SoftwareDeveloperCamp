using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
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

        public void Add(Car car)
        {
            if (car.Description.Length<2 || car.DailyPrice<=0)
            {
                Console.WriteLine("Araç Açıklaması En Az 2 Karakter Ve Araç Kiralama Fiyatı 0'dan Büyük Olmalı");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Ekleme İşlemi Başarılı");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araç Silindi");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandID==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorID == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Güncelleme İşlemi Başarılı");
        }
    }
}
