using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using NLog;

namespace HW_12
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        [Atribute(client ="ФЛ")]
        static public void Main(string[] args)
        {
            log.Debug("Hello! It's bag");
            log.Trace("Закомменчен рабочий код, который имеет недостатки при сортировке");
            /*List<Class2> c = new List<Class2>();
            c.Add(new Class2() { k = "без комиссии" };
            foreach (Class2 c1 in c)
            {
                Console.WriteLine(c1.k);
            }*/
            /*Dictionary<double, string> c = new Dictionary<double, string>();
            c.Add(7.6, "ghh");
            foreach (KeyValuePair<double, string> keyValue in c)
            {
                Console.WriteLine(keyValue.Key + " руб. " + keyValue.Value);
            }*/

            Class1 FirstSevices = new Class1();
            Class1 SecondSevices = new Class1();

            Console.WriteLine("Введите услуги к оплате клиента1:");
            Payment.SetPayment(FirstSevices);
            Console.WriteLine("");
            Console.WriteLine("Услуги к оплате клиента1:");
            Payment.GetPayment(FirstSevices);
            Console.WriteLine("");
            Console.WriteLine("Введите услуги к оплате клиента2:");
            Payment.SetPayment(SecondSevices);
            Console.WriteLine("");
            Console.WriteLine("Услуги к оплате клиента2:");
            Payment.GetPayment(SecondSevices);

        }
    }   
}
