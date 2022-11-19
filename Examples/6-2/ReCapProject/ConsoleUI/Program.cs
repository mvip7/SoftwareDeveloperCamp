using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.InMemory;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new InMemoryCarDal());
            
            Car car = new Car
            {
                ID = 6,
                BrandID = 4,
                DailyPrice = 190,
                Description = "Toyata Marka Araç",
                ColorID = 2,
                ModelYear = "2018"
            };

            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.ID + " - " + item.Description);
            }
            Console.WriteLine("\n");

            _carManager.Add(car);
            _carManager.Delete(car);
            Console.WriteLine("\n");

            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.ID + " - " + item.Description);
            }
            Console.WriteLine("\n");

            car.Description = "BMW Marka Araç";
            _carManager.Update(car);
            Console.WriteLine("\n");

            //foreach (var item in _carManager.GetAll())
            //{
            //    Console.WriteLine(item.ID + " - " + item.Description);
            //}
            //Console.WriteLine("\n");

            List<Car> listCar = new List<Car>();
            var result = listCar.Where(c=>c.ID==3);
            foreach (var item in result)
            {
                Console.WriteLine(item.Description);
            }
            result.ToList();

            //foreach (var item in _carManager.GetById())
            //{
            //    Console.WriteLine(item.ID);
            //}



            Console.WriteLine("\nSON");
        }

    }
}
