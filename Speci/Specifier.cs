using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Speci
{
    internal class Specifier
    {
        public void Test1()
        {
            Console.WriteLine("Test1 public method");
        }
        private void Test2()
        {
            Console.WriteLine("Test2 private method");
        }
        protected void Test3()
        {
            Console.WriteLine("Test3 protected method");
        }
        internal void Test4()
        {
            Console.WriteLine("Test4 internal method");
        }
        protected internal void Test5()
        {
            Console.WriteLine("Test5 protected internal method");
        }

    }
}
