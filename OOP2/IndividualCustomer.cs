using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer : Customer
    {
        public int CustomerID { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastname { get; set; }
    }
}
