using _5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace _5_5.Abstract
{
    class MernisCheckManager : IMernisCheckService
    {
        public bool CheckUser(Users users)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(users.NationalID, users.Name.ToUpper(),
                users.LastName.ToUpper(), users.BirthOfDate.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
