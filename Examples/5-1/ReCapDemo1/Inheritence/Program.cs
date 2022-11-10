using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Mevzuat mevzuat = new Mevzuat();
        }
    }
    abstract class Mevzuat
    {
        public Mevzuat()
        {
            Console.WriteLine("Ctor Yapısı");
        }
    }
    class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Customer : Person
    {

    }

}
