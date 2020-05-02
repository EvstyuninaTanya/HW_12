using System;
using System.Collections.Generic;
using System.Text;

namespace HW_12
{
    public abstract class Result
    {
        static public double r;
        public abstract void Res(Class1 S, Class1 C);

        public void GetResult()
        {
            Console.WriteLine("К оплате: {0} руб.", r);
            Console.WriteLine("");
        }
    }
}
