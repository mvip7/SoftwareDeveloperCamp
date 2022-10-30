using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerCreditManager : ICrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı");
        }
    }
}
