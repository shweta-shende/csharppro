using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Projectc1.Inheritance
{
    internal class Inheri1
    {
        public Inheri1(){
            Console.WriteLine("super class constructor");
        }
    }
    class Inheri2 : Inheri1{
        public Inheri2()
        {
           
            Console.WriteLine("sub class constructor");
        }
        static void inheritt()
        {
            Inheri2 i=new Inheri2();  
            
        }
    }
}
