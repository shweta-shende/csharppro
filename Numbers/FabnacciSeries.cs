using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class FabnacciSeries
    {
        static void Main1()
        {
            Console.WriteLine("enter first number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of series");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(a+"");
            Console.WriteLine(b+"");
            for(int i = 1; i<=n; i++)
            {
                int c = a+b;
                Console.WriteLine(c+"");
                a = b;
                b = c;
            }
        }
    }
}
