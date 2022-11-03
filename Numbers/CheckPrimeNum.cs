using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class CheckPrimeNum
    {
        static void Mmmm1()
        {
            Console.WriteLine("enter a number");
       int   n = int.Parse(Console.ReadLine());
            int i;
            if(n==1)
            {
                Console.WriteLine("prime starts from 2");
            }
            for(i = 2; i < n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("its not prime number");
                break;
            }
            if (n == i)
            {
                Console.WriteLine();
                Console.WriteLine(  );
                Console.WriteLine("its a prime number");
            }
            }
    }
}
