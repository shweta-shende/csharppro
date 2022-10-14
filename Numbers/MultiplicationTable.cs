using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Numbers
{
    internal class MultiplicationTable
    {
        static void Maiiiiiii()
        {
            Console.WriteLine("enter a number");
           int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n+"*"+i+"="+(n*i));   
            }
        }
    }
}
