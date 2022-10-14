using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Basics
{
    internal class Program1
    {
        public static void UserNameNAge()
        {
            Console.WriteLine("enter a name");
         string  Name= Console.ReadLine();
            Console.WriteLine(Name);
            Console.WriteLine("enter a age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);
            Console.WriteLine(Name +" "+age);


        }
        
    }
}
