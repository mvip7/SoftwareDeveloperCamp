using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product disk = new Product(50);
            Product phone = new Product(60);
            phone.StockControlEvent += Phone_StockControlEvent;
            disk.StockControlEvent += Disk_StockControlEvent;

            disk.ProductName = "Harddisk";
            phone.ProductName = "IPhone";
            for (int i = 0; i < 5; i++)
            {
                disk.Sells(8);
                phone.Sells(8);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Disk_StockControlEvent()
        {
            Console.WriteLine("");
        }

        private static void Phone_StockControlEvent()
        {
            Console.WriteLine("Telefon Stok Miktari Düşük Seviyede");
        }
    }
}
