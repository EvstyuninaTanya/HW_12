using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace HW_12
{
    public class Payment : Result
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        static Dictionary<double, string> c = new Dictionary<double, string>();
        /*static List<double> a = new List<double>();
        static List<string> b = new List<string>();*/
        static public void SetPayment(Class1 Payment)
            {
                try
                {
                    Console.Write("Введите количество платежей: ");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Class1 s1 = new Class1();
                    //Array.Resize<double>(ref Payment.a, k);
                    //Array.Resize<string>(ref Payment.b, k);
                for (int i = 0; i < k; i++)
                    {
                        Console.Write("Платёж {0}: ", i + 1);
                        Console.WriteLine("");
                        Console.Write("Введите вариант оплаты: 1 - без комиссии, 2 - с комиссией: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        switch (n)
                        {
                            case 1:
                                Console.Write("Введите сумму платежа: ");
                                Sums x = new Sums { s = int.Parse(Console.ReadLine()) };
                                Console.WriteLine("");
                                x.GetValue();
                                x.SetSums(s1);
                                Result1 z = new Result1();
                                z.Res(s1, s1);
                                z.GetResult();
                                c.Add(r, "без комиссии");
                                /*a.Add(r);
                                b.Add("без комиссии");*/
                                //Payment.b[i] = "c комиссией";
                                //Payment.a[i] = r;
                                break;
                            case 2:
                                Console.Write("Введите сумму платежа: ");
                                x = new Comis { s = int.Parse(Console.ReadLine()) };
                                Console.WriteLine("");
                                x.GetValue();
                                x.SetSums(s1);
                                Comis y = new Comis();
                                y.SetComis(s1, s1);
                                y.GetComis(s1);
                                Result2 v = new Result2();
                                v.Res(s1, s1);
                                v.GetResult();
                                c.Add(r, "руб. c комиссией");
                                /*a.Add(r);
                                b.Add("c комиссией");*/
                                //Payment.b[i] = "c комиссией";
                                //Payment.a[i] = r;
                                break;
                            default:
                                Console.Write("Ошибка: Не верный ввод!");
                                break;
                        }
                    }
                }
                catch (Exception)
                {
                    log.Error("Ошибка: Неверный ввод!");
                    //Console.WriteLine("Ошибка: Неверный ввод!");
                    //Console.ReadLine();
                }
            }

            static public void GetPayment(Class1 Payment)
            {
            c = c.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<double, string> keyValue in c)
            {
                Console.WriteLine("Платёж: {0}", keyValue.Key + " руб. " + keyValue.Value);
            }
            c.Clear();
            //a.Sort();
            /*for (int i = 0; i < a.Count; i++)
                {
                    Console.Write("Платёж {0}: {1}", i+1, + a[i] + " руб. ");
                    Console.WriteLine(b[i] + "; ");
                }
                //int d = b.where(e => e == "без комиссии").Count();
                //Console.Write("Количество платежёй без комиссии: {0}", d);
                a.Clear();
                b.Clear();*/

            /*for (int i = 0; i < Payment.a.Length; i++)
            {
                Console.WriteLine("Услуга {0}", Payment.b[i]);
                Console.WriteLine("{0} руб.", Payment.a[i]);
            }*/
        }

        public override void Res(Class1 S, Class1 C)
        {
            throw new NotImplementedException();
        }
    }
}
