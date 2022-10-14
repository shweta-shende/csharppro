using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class SwapTwoNoWithoutUsing3rdVariable
    {
        static void Main8() {
            int a = 40,  b = 90;
            Console.WriteLine("before swapping");
            Console.WriteLine("value of a is "+a);
            Console.WriteLine("value of b is "+b);
             a = a + b;
             b = a - b;
             a = a - b;
            Console.WriteLine("after swapping");
            Console.WriteLine("value of a is " + a);
            Console.WriteLine("value of b is " + b);

        }

    }
}
