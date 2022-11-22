using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
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
            CarManager _carManager = new CarManager(new EFCarDal());
            ColorManager _colorManager = new ColorManager(new EFColorDal());
            
            Car car = new Car
            {
                ID = 6,
                BrandID = 4,
                DailyPrice = 150,
                Description = "Toyata Marka Araç",
                ColorID = 2,
                ModelYear = "2018"
            };

            foreach (var item in _colorManager.GetAll())
            {
                Console.WriteLine(item.ColorName);
            }
            foreach (var item in _carManager.GetCarInfo())
            {
                Console.WriteLine("{0}/{1}/{2}/{3}",item.CarId,item.Brand,item.Color,item.DailyPrice);
            }
            
            //_carManager.Add(car);
            //_carManager.Delete(car);         

            car.Description = "BMW Marka Araç";
            //_carManager.Update(car);


            Console.WriteLine("\nSON");
            Console.ReadLine();
        }
    }
}
