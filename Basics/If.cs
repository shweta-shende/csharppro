using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class If
    {
        public static void Vote()
        {
            int age = 21;
            if(age>=18)
            {
                Console.WriteLine("you are eligible to vote");
            }
            else
            {
                Console.WriteLine("you are not eligible to vote");
            }
        }
    }
}
