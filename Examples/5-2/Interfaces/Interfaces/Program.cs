using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager personManager = new CorporateManager();
            
            IPersonManager customerManager = new CustomerManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(personManager);
        }

        // Interface'ler new ile yeni bir nesne oluşturulmaz
        interface IPersonManager
        {
            void Add();
            void Update();
        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Customer Manager Ekleme İşlemi");
            }

            public void Update()
            {
                Console.WriteLine("Customer Güncelleme İşlemi");
            }
        }
        class CorporateManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Corporate Manager Ekleme İşlemi");
            }

            public void Update()
            {
                Console.WriteLine("Customer Güncelleme İşlemi");
            }
        }
        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }
        }
    }
}
