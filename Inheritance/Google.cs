using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Inheritance
{
    internal class Google
    {
        public Google()
        {
            Console.WriteLine("google account created");
        }
    }
    class Youtube : Google
    { 
        public Youtube()
        {
            Console.WriteLine("youtube vedios uploaded");
        }
    }
    class Insta : Google
    {
        public Insta()
        {
            Console.WriteLine("insta account created");
        }
        static void Maineeeeee()
        {
            Youtube y = new Youtube();
            Insta x = new Insta();
        }
    }
}
