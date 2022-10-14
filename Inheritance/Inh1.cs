using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Inheritance
{
    internal class Inh1
    {
        public Inh1()
            {
            Console.WriteLine("constructor with 0 parameter");
 
            }
    }
    class Inhr2 : Inh1
    {
        public Inhr2():base()
        {

        }
        static void Inhhhttt()
        {
            Inhr2 h=new Inhr2();
        }

    }
}
