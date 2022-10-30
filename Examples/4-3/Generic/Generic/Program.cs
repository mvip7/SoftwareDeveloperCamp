using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> byList = new List<string>();
            byList.Add("Yunus");
            Console.WriteLine(byList[0]);

            Vehicles<string> vehicles = new Vehicles<string>();
            vehicles.Add("BMW");
            vehicles.Add("BMW");
            vehicles.Add("BMW");
            vehicles.Add("BMW");
            Console.WriteLine(vehicles[1]);

        }
    }
}
