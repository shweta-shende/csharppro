using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class StrongNum
    {
        static void Main11()
        {
            Console.WriteLine("enter the number");
            int n=int.Parse(Console.ReadLine());
            int a = n;
            int sum = 0;
            while (n > 0)
            {
                int f = 1;
                int r = n % 10;
                for(int i = 1; i <= r; i++)
                {
                    f = f * i;
                }
                sum= sum + f;   
                n=n/ 10;    
            }
            if(sum == a)
            {
                Console.WriteLine("number " + a + " is strong number");
            }
            else
            {
                Console.WriteLine("number " + a + " is not strong number");
            }
        }
    }
}
