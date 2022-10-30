using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService)
        {
            crediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmeYap(List<ICrediManager> crediManagers,List<ILoggerService> loggerService)
        {
            foreach (var item in crediManagers)
            {
                item.Hesapla();
                
            }
            foreach (var item in loggerService)
            {
                item.Log();
            }
        }


  }
}
