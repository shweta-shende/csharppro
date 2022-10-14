using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Inheritance
{
    internal class AnimalInher
    {
        public AnimalInher()
        {
            Console.WriteLine("animal sound ");
        }
    }
    class Dog : AnimalInher
    {
        public Dog()
        {
            Console.WriteLine("dog sound");
        }

    }
    class BabyDog : Dog
    {
        public BabyDog()
{
            Console.WriteLine("babydog sound");
            
        }   
        static void Mainnnnnnn()
        {
             
            BabyDog c=new BabyDog();

        }

    }

}
