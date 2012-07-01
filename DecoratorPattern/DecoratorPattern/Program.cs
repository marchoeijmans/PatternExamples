using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = DecoratorPattern.BeforeRefactor;
using AR = DecoratorPattern.AfterRefactor;

// Decorator (extender) pattern waarmee classen kunnen worden uitgebreid.
namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BR.Computer computer1 = new BR.Computer();
            Console.WriteLine(computer1.getDescription());

            AR.Computer computer = new AR.Computer();
            computer = new AR.Disk(computer);
            computer = new AR.CD(computer);
            computer = new AR.CD(computer);
            computer = new AR.Monitor(computer);
            Console.WriteLine("Dit is een: " + computer.getDescription());

            Console.ReadLine();
        }
    }
}
