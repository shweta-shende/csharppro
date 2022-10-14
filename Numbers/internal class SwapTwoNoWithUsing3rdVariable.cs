using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class SwapTwoNoWithUsing3rdVariable
    {
        static void Main9()
        {
            int a = 33, b = 22;
            int temp;
            Console.WriteLine("before swapping");
            Console.WriteLine("value of a is "+a);
            Console.WriteLine("value of b is "+b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping");
            Console.WriteLine("value of a is " + a);
            Console.WriteLine("value of b is " + b);
            a = a + b;
            b = a - b;
            a = a - b;




        }
    }
}
