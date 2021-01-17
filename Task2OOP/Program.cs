using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Task2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(5.231m);
            Money.Operations(9.00m);
            Console.WriteLine(m.ToString());
            Console.ReadLine();
        }
    }
}
