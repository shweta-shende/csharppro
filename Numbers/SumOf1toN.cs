using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class SumOf1toN
    {
        static void Mmmmm()
        {
            Console.WriteLine("enter value of n");
         int  n =int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <=n; i++)
            {
                sum= sum + i;   
            } 
            Console.WriteLine(sum);
        }
    }
}
