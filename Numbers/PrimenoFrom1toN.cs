using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class PrimenoFrom1toN
    {
        static void Maain()
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("prime number between 1 and " + n);
            //loop through the num one by one
            for (int i = 2; i < n; i++)
            {
                Boolean isPrime = true;
                //check to see if the num is prime
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //prime the number
                if (isPrime)
                    Console.WriteLine(i + " ");


            }
        }
    }
}
