using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Constructor
{
    internal class Demo2
    {
        int i;
        public Demo2(int x)
        {
           i= x;
        }
        public Demo2 (Demo2 obj)
        {
            i= obj.i;
        }
        public void Display()
        {
            Console.WriteLine(" inside implemented constructor : "+i);
        }
        static void MethodDis()
        {
            Demo2 d = new Demo2(5);
            d.Display();
            Demo2 D1 = new Demo2(d);
            D1.Display();
        }
    }
}
