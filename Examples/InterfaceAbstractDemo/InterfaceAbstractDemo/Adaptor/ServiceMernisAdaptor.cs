using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adaptor
{
    public class ServiceMernisAdaptor : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalID, customer.CustomerName,
                customer.CustomerLastname, customer.DateofBirth.Year);

        }
    }
}
