using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HW_12
{
    public class Sums: Interface1
    {
        private int Sum;
        public int s
        {
            set { Sum = value; }
            get { return Sum; }
        }
      
        public void GetValue()
        {
            Console.WriteLine("Сумма платежа: {0} руб.", s);
            Console.WriteLine("");
        }
        public void SetSums(Class1 S)
        {
            S.x = s;
        }
    }
}
