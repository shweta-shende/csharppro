using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class ArmStrongNumber
    {
        static void Mainnn()
        {
            Console.WriteLine("enter a number");
           int n= int.Parse(Console.ReadLine());
            int a = n;
            int sum= 0;
            while (n > 0)
            {
                int r = n % 10;
                sum= sum + r*r*r;
                n= n / 10;
            }
            if (sum == a)
            {
                Console.WriteLine("number "+a+" is armstrong number");
            }
            else
            {
                Console.WriteLine("number " + a + " is not armstrong number");
            }
        }
    }
}
