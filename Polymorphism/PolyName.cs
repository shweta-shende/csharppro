using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Polymorphism
{
    internal class PolyName
    {
        public void Name()
        {
            Console.WriteLine("no parameter");
        }
        public void Name(string s,string s1)
        {
            Console.WriteLine("with parameter string");
        }
        public void Name(char c,int n)
        {
            Console.WriteLine("different in argument");
        }
        static void Main3()
        {
            PolyName po = new PolyName(); 
            po.Name();
            po.Name("shweta", "shende");
            po.Name('f', 22);    
        }
    }
}
