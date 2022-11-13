using _5_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_5.Entities
{
    public class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long NationalID { get; set; }
        public DateTime BirthOfDate { get; set; }
    }
}
