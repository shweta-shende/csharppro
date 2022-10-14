using Projectc1.Speci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Speci
{
    public interface IaJavaa
    {
        void developersName()
        {

        }
    }
    public interface IcSharp
    {
        void developersName()
        {

        }
    }

    
}
internal class Selenii : IaJavaa, IcSharp
{
    void IcSharp.developersName()
    {
        Console.WriteLine("c sharp lang");
    }
    void IaJavaa.developersName()
    {
        Console.WriteLine("java lang");
    }
    static void Main()
    {
        IaJavaa j = new Selenii();
        j.developersName();
        IcSharp i = new Selenii();
        i.developersName();
    }
}
    

