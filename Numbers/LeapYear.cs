using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class LeapYear
    {
        static void Main88()
        {
            Console.WriteLine("enter a year");
          int n =int.Parse(Console.ReadLine());
            if(n%4==0 && n%100!=0 || n%400==0)
                Console.WriteLine(n+" is a leap year");
            else
            {
                Console.WriteLine(n+" is not leap year");
            }

        }
    }
}
