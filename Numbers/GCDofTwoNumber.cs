using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class GCDofTwoNumber
    {
        static int gcd(int m,int n)
        {
            if(m<n)
                return gcd(n,m);
            if(n==0)
                return m;  
            return gcd (n,m%n);
        }
        static void Main7()
        {
            Console.WriteLine("enter two numbers");
          int  a=int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c=gcd(a,b);
            Console.WriteLine(c);
        }
    }
}
