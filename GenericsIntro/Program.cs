using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> myList = new MyList<string>();
            //myList.Add("Mert");


            int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            int[] sayilar2 = new int[] { 10, 20, 30, 40,50,60};

            sayilar1 = sayilar2;
            sayilar2[0] = 100;
            Console.WriteLine("Sayilar1[0] = "+sayilar1[0]);
        }
    }
}
