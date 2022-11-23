using BusinessLayer.Abstract;
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
        public void Add(Car car)
        {
            if (car.Description.Length < 2 || car.DailyPrice <= 0)
            {
                Console.WriteLine("Arac Açıklamasi En Az 2 Karakter Ve Arac Kiralama Fiyati 0'dan Buyuk Olmali");
            }
            else if (car.ID==car.ID)
            {
                Console.WriteLine("Ekleme Islemi Basarisiz. Bu Arac Daha Once Eklenmis !!!");
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

        public List<CarInfoDto> GetCarInfo()
        {
            return _carDal.GetCarInfo();
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
