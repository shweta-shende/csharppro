using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class PerfectNum
    {
        static void Main4()
        {
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            int sum = 1;
            for(int i = 2; i<= n/2; i++)
            {
                if (n % i == 0)
                    sum = sum + i;
            }
            if (sum == n)
            {
                Console.WriteLine(n+" is a perfect number");
            }
            else
            {
                Console.WriteLine(n+" is not perfect number");
            }
        }
    }
}
