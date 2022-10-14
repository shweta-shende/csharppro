using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Inheritance
{
    internal class Multilevel
    {
        public  void M1()
        {
            Console.WriteLine("super class ");
        }
    }
    class A :Multilevel
    {
        public void M2()
        {
            Console.WriteLine("sub class");
        }
    }
    class B:A
    {
        public void M3()
        {
            Console.WriteLine("sub sub class");
        }
        static void Main6()
        {
            B b = new B();
            b.M1();
            b.M2(); 
            b.M3();
            A a = new A();
            a.M1(); 
            a.M2(); 
            
        }

    }
}
