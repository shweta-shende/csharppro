using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class FactorialOfGivenNum
    {
        static void Main1()
        {
            Console.WriteLine("enter the number");
           int n= int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i<=n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);    
        }
    }
}
