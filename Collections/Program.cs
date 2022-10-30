using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> isimler = new List<string> { "Yunus", "Mark", "Alla", "Amırğ" };
            isimler.Add("Sofiya");
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i].ToString());
            }
        }
    }
}

