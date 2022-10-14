using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Polymorphism
{
    internal class RunSuper
    {
        public virtual void display()
        {
            Console.WriteLine("super class method");
        }
    }
    class RunSub: RunSuper  
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("sub class method");
        }
        static void Main7()
        {
            RunSub r = new RunSub();
            r.display();    
        }

    }
}
