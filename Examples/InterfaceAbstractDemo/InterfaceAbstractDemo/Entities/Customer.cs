using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NationalID { get; set; }
    }
}
