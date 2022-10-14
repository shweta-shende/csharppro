using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Inheritance
{
    internal class Google1
    {
        public void Account()
        {
            Console.WriteLine("google account is created");
        }
    }
    class Youtubee:Google1
    {
        public void UploadVedios()
        {
            Console.WriteLine("vedios are uploaded");
        }

    }
    class GoogleDrive:Google1
    {
        public void UploadFile()
        {
            Console.WriteLine("Files are uploaded");
        }

    }
    class GMail : Google1
    {
        public void ComposeMail()
        {
            Console.WriteLine("mail has been sent");
        }
        static void Mainn()
        {
            Google1 g = new Google1();
            g.Account();
            Console.WriteLine("------------------------------");
            Youtubee y = new Youtubee();
            y.Account();
            y.UploadVedios();
            Console.WriteLine("-------------------------------");
            GoogleDrive d = new GoogleDrive();
            d.Account();    
            d.UploadFile();
            Console.WriteLine("--------------------------------");
            GMail m = new GMail();
            m.Account();    
            m.ComposeMail();

            
         
        }

    }
}
