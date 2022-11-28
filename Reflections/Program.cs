using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflections
{
    public delegate void MyDelegate();
    public delegate int ResultDelegate(int num1, int num2);
    class Program
    {


        static void Main(string[] args)
        {

            //var type = typeof(Transactions);
            //Transactions fourTransactions = (Transactions)Activator.CreateInstance(type, 5, 4);
            //Console.WriteLine(fourTransactions.Sum());
            //Console.WriteLine(fourTransactions.Multiply2(5, 6));


            //var instance = Activator.CreateInstance(type,5,2);
            //MethodInfo methodInfo = instance.GetType().GetMethod("Sum");
            //Console.WriteLine(methodInfo.Invoke(instance,null));

            //var methods = type.GetMethods();
            //foreach (var item in methods)
            //{
            //    Console.WriteLine("\n"+item.Name);
            //    foreach (var parameterInfo in item.GetParameters())
            //    {
            //        Console.WriteLine(parameterInfo);
            //    }
            //}

            Message _message = new Message();
            Test _test = new Test();

            MyDelegate myDelegate = _message.SendMessage;
            myDelegate();

            ResultDelegate resultDelegate = _test.Sums;
            resultDelegate += _test.Multiply;

            for (int j = 1; j < 5; j++)
            {
                var total = resultDelegate(12, j);
                Console.WriteLine(total);
            }
            Console.ReadLine();
        }
        public class Transactions
        {
            int _sayi1;
            int _sayi2;
            public Transactions(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public int Sum()
            {
                return _sayi1 + _sayi2;
            }
            public int Sum2(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Multiply()
            {
                return _sayi2 * _sayi1;
            }
            public int Multiply2(int sayi1, int sayi2)
            {
                return sayi2 * sayi1;
            }
        }
        public class Message
        {
            public void SendMessage()
            {
                Console.WriteLine("İşlem Sonucu Hesaplandı !!! ");
            }
        }
        public class Test
        {
            public int Sums(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
            }
            public int Multiply(int num1, int num2)
            {
                int result = num1 * num2;
                return result;
            }            
        }

    }
}
