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

            _colorManager.Add(new Color
            {
                Id = 5,
                ColorName = "Green"
            });
            _carManager.Add(new Car
            {
                ID = 10,
                BrandID = 3,
                DailyPrice = 180,
                Description = "FIAT Marka Araç",
                ColorID = 5,
                ModelYear = 2016
            });
            foreach (var item in _colorManager.GetAll())
            {
                Console.WriteLine(item.ColorName);
            }
            Console.WriteLine("\n");
            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }

            // Araç Bilgileri Join İşlemi
            foreach (var item in _carManager.GetCarInfo())
            {
                Console.WriteLine("{0}/{1}/{2}/{3}", item.CarId, item.Brand, item.Color, item.DailyPrice);
            }


            Console.WriteLine("\nSON");
            Console.ReadLine();
        }
    }
}
