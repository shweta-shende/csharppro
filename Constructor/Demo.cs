using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Constructor
{
    internal class Demo
    {
        static Demo()
        {
            Console.WriteLine("static constructor");
        }
        static void StartProgram()
        {
            Console.WriteLine("here main started");
        }
    }
}
