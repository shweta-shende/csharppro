using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Polymorphism
{
    internal class Poly1
    {
        int a=10, b=50;
        public void add()
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public void add(int a,int b)
        {
            int sum =a + b;
            Console.WriteLine(sum);
        }
        static void Maine()
        {
            Poly1 p = new Poly1();  
            p.add();
            p.add(5,5);
        }
    }
    
}
