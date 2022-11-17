using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{ID=1,CarBrandID=2,ModelYear="2015",ColorID= "186, 186, 186",DailyPrice=240,Description="Hızlı Araba"},
                new Car{ID=2,CarBrandID=1,ModelYear="2016",ColorID= "168, 210, 132",DailyPrice=280,Description="Şehiriçi Araba"},
                new Car{ID=3,CarBrandID=4,ModelYear="2020",ColorID= "240, 140, 180",DailyPrice=290,Description="Yeni ve Hızlı Araba"},
                new Car{ID=4,CarBrandID=5,ModelYear="2005",ColorID= "165, 185, 135",DailyPrice=180,Description="Eski Araba"},
                new Car{ID=5,CarBrandID=6,ModelYear="2012",ColorID= "197, 124, 212",DailyPrice=220,Description="Az Yakan Araba"},
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

        public List<Car> GetAll()
        {
            return listOfCars;
        }

        public List<Car> GetByID()
        {
            return listOfCars;
        }

        public void Update(Car cars)
        {
            findCar = listOfCars.FirstOrDefault(c=>c.ID==cars.ID);
            findCar.ColorID = cars.ColorID;
            findCar.CarBrandID = cars.CarBrandID;
            findCar.DailyPrice = cars.DailyPrice;
            findCar.Description = cars.Description;
            findCar.ModelYear = cars.ModelYear;
            Console.WriteLine("ID Numarası {0} Olan Araç Başarıyla Güncellenmiştir",cars.ID);

        }
    }
}
