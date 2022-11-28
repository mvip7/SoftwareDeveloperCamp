using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int StocksUnit
        {
            get { return _stock; }
            set
            {
                _stock = value;
                if (value<=20)
                {
                    StockControlEvent();
                }
            }
        }
        public void Sells(int amount)
        {
            StocksUnit -= amount;
            Console.WriteLine("{0} Urununden {1} Adet Satış Olmuştur",ProductName,StocksUnit);
        }
    }
}
