using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFactory.BusinessLayer;

namespace SimpleFactory.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Namer namer = new NameFactory().getName("FirstName LastName");
            Console.WriteLine(namer.getFirstName());
            Console.WriteLine(namer.getLastName());

            Namer namer2 = new NameFactory().getName("LastName, FirstName");
            Console.WriteLine(namer2.getFirstName());
            Console.WriteLine(namer2.getLastName());

            Console.ReadLine();
        }
    }
}
