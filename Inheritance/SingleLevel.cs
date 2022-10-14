using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Inheritance
{
    internal class SingleLevel
    {
        public void Add()
        {
            int a = 10, b = 20, c;
            c = a + b;
            Console.WriteLine(c);
        }
        public void Sub()
        {
            int a = 40, b = 20, c;
            c = a - b;
            Console.WriteLine(c);
        }

    }
    class Sub: SingleLevel
    {
        public void Mul()
        {
            int a = 5, b = 6, c;
            c = a * b;
            Console.WriteLine(c);
        }
        public void Div()
        {
            int a = 40, b = 20, c;
            c = a / b;
            Console.WriteLine(c);
        }
        static void Main2()
        {
            Sub s = new Sub();
            s.Mul();
            s.Add();
            s.Sub();
            s.Div();
        }

    }
}
