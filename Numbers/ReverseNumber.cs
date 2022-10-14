using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class ReverseNumber
    {
        static void Main1()
        {
            Console.WriteLine("enter a number");
          int  n=int.Parse(Console.ReadLine());
            int a = n;
            int rev = 0;
            while (n != 0)
            {
                rev = rev * 10 + (n % 10);
                n = n / 10;
            }
            Console.WriteLine(rev);

        }

    }
}
