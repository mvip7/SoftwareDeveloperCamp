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
            //ListColorTest();
            //CarDetails();
            CarListTest();

            // Araç Bilgileri Join İşlemi
            

            Console.WriteLine("\nSON");
            Console.ReadLine();
        }

        private static void ListColorTest()
        {
            ColorManager _colorManager = new ColorManager(new EFColorDal());
            var result = _colorManager.GetAll();

            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " / " + item.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarListTest()
        {
            CarManager _carManager = new CarManager(new EFCarDal());
            var result = _carManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void CarDetails()
        {
            CarManager _carManager = new CarManager(new EFCarDal());
            foreach (var item in _carManager.GetCarInfo().Data)
            {
                Console.WriteLine("{0}/{1}/{2}/{3}", item.CarId, item.Brand, item.Color, item.DailyPrice);
            }
        }
    }
}
