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
            //CarListTest();

            RentalsInfoManager rentalsManager = new RentalsInfoManager(new EfRentalsInfoDal());
            rentalsManager.Add(new RentalsInfo { Id=4,CarId=3,CustomerId=1,RentDate=DateTime.Today,ReturnDate=new DateTime(2022,12,5) });
            var result = rentalsManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarId+" / "+ item.CustomerId);
            }
            
            // Customer İşlemi
            //CustomerAddTest();
            //CustomerListTest();

            Console.WriteLine("SON");
        }

        private static void CustomerListTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());            
            var result = customerManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CompanyName);
            }            
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id=3, UserId = 4, CompanyName = "Deneme" });
        }

        private static void ListColorTest()
        {
            ColorManager _colorManager = new ColorManager(new EfColorDal());
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
            CarManager _carManager = new CarManager(new EfCarDal());
            var result = _carManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Description);
            }
        }

        private static void CarDetails(int id)
        {
            CarManager _carManager = new CarManager(new EfCarDal());
            foreach (var item in _carManager.GetCarInfo(id).Data)
            {
                Console.WriteLine("{0}/{1}/{2}/{3}", item.CarId, item.Brand, item.Color, item.DailyPrice);
            }
        }
    }
}
