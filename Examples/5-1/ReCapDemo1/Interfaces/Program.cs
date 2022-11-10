using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class RobotsWorker : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
