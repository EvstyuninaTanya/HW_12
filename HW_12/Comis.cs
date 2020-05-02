using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HW_12
{
    public class Comis : Sums, Interface2
    {

       public void SetComis(Class1 S, Class1 C)
        {
            Console.Write("Введите % комиссии: ");
            C.y = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            C.y = C.y * S.x / 100;
        }

       public void GetComis(Class1 C)
        {
            Console.WriteLine("Сумма комиссии: {0} руб.", C.y);
            Console.WriteLine("");
        }
    }
}
