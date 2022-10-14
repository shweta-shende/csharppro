using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class PallindromeNo
    {
        static void Mainn()
        {
            Console.WriteLine("enter a number");
          int n= int.Parse(Console.ReadLine());
            int a = n;
            int sum = 0;
            while (n > 0)
            {
                int r = n % 10;
                sum = sum * 10 + r;
                n=n/ 10; 
            }
            if(sum == a)
            {
                Console.WriteLine("the number "+a+" is pallindrome");
            }
            else
            {
                Console.WriteLine("the number "+a+" is not pallindrome");
            }
        }
    }
}
