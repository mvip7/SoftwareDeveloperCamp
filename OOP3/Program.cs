using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerCreditManager consumerCreditManager = new ConsumerCreditManager();
            VehicleLounManager vehicleLounManager = new VehicleLounManager();
            HousingLoanManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(consumerCreditManager,databaseLoggerService);

            List<ICrediManager> crediManagers1 = new List<ICrediManager>()
            {
            consumerCreditManager,housingLoanManager
            };

            List<ILoggerService> loggerServices  = new List<ILoggerService>()
            {
            databaseLoggerService,fileLoggerService
            };

            applicationManager.KrediOnBilgilendirmeYap(crediManagers1,loggerServices);



        }
}
}
