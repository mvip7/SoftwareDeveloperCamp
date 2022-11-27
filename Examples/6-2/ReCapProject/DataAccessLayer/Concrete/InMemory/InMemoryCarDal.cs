using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> listOfCars;
        Car findCar;

        public InMemoryCarDal()
        {
            listOfCars = new List<Car>
            {
                new Car{ID=1,BrandID=2,ModelYear=2015,ColorID=2,DailyPrice=240,Description="Hızlı Araba"},
                new Car{ID=2,BrandID=1,ModelYear=2016,ColorID=3,DailyPrice=280,Description="Şehiriçi Araba"},
                new Car{ID=3,BrandID=4,ModelYear=2020,ColorID=4,DailyPrice=290,Description="Yeni ve Hızlı Araba"},
                new Car{ID=4,BrandID=5,ModelYear=2005,ColorID=6,DailyPrice=180,Description="Eski Araba"},
                new Car{ID=5,BrandID=6,ModelYear=2012,ColorID=7,DailyPrice=220,Description="Az Yakan Araba"},
            };
        }

        public void Add(Car cars)
        {
            findCar = listOfCars.FirstOrDefault(c=>c.ID==cars.ID);/* c elemanını dışarıdan istenen cars ile eşleşirse bunu findCar
                                                                       * elemanında tut*/
            if (findCar==null)
            {
                listOfCars.Add(cars);
                Console.WriteLine("Araç Ekleme İşlemi Başarıyla Gerçekleşti !!!");
            }
            else
            {
                Console.WriteLine("Eklemeye Çalıştıgınız Araç Sistem Zaten Kayıtlı !!!");
            }

        }

        public void Delete(int ID)
        {
            findCar = listOfCars.FirstOrDefault(c=>c.ID==ID);

            if (findCar!=null)
            {
                listOfCars.Remove(findCar);
                Console.WriteLine("Silme İşlemi Gerçekleşti !!!");
            }
            else
            {
                Console.WriteLine("Sistemde Böyle Bir Araç Bulunmuyor");
            }
            
        }

        public void Delete(Car item)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return listOfCars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID()
        {
            return listOfCars;
        }

        public List<CarInfoDto> GetCarInfo()
        {
            throw new NotImplementedException();
        }

        public List<CarInfoDto> GetCarInfo(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car cars)
        {
            findCar = listOfCars.FirstOrDefault(c=>c.ID==cars.ID);
            findCar.ColorID = cars.ColorID;
            findCar.BrandID = cars.BrandID;
            findCar.DailyPrice = cars.DailyPrice;
            findCar.Description = cars.Description;
            findCar.ModelYear = cars.ModelYear;
            Console.WriteLine("ID Numarası {0} Olan Araç Başarıyla Güncellenmiştir",cars.ID);

        }
    }
}
