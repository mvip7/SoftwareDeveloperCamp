using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.InMemory;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;

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
                CarBrandID = 4,
                DailyPrice = 190,
                Description = "Toyata Marka Araç",
                ColorID = "73, 90, 94",
                ModelYear = "2018"
            };

            _carManager.Add(car);

            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.ID + " - " + item.Description);
            }

            _carManager.Delete(4);

            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.ID + " - " + item.Description);
            }

            //foreach (var item in _carManager.GetById())
            //{
            //    Console.WriteLine(item.ID);
            //}

            Console.ReadLine();
        }

    }
}
