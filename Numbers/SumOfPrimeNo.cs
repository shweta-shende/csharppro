using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class SumOfPrimeNo
    {
        static void Mainnnnnnnnn()
        {
            Console.WriteLine("enter the number");
          int  n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                if(isPrime(i))
                sum= sum + i;   
            }
            Console.WriteLine(sum); 
        }
        public static Boolean isPrime(int num)
        {
            if(num == 1)
                return false;    
            for(int i = 2; i < num; i++)
            {
                if( num%i==0)
                {
                    return false;    
                }
            }
            return true;    
        }
    }
}

