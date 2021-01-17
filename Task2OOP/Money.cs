using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Task2OOP
{
    class Money
    {
        public static decimal cash;
        public Money(decimal cash)
        {
            this.Cash = cash;
           
            
        }
        public decimal Cash
        {
            get { return cash; }
            set { if (value < 0.0m) { cash = 0.0m; }
                else  cash = value;             }
        }

        public static decimal Operations(decimal l)
        {
            return cash += l; 
        }

        public override string ToString()
        {
            var p = cash.ToString("F", CultureInfo.InvariantCulture);
            var p1=  cash.ToString("N", CultureInfo.InvariantCulture);
            return p + " "+ p1;
        } 

    }
}
