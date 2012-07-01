using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LawOfDemeterExample.Improved;
using LawOfDemeterExample.Violation;

namespace LawOfDemeterExample
{
    /// <summary>
    /// Example, inspired by:
    /// http://www.ccs.neu.edu/research/demeter/demeter-method/LawOfDemeter/paper-boy/demeter.pdf
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Customer1 Has 20 Dollar");
            Violation.Customer Customer1 = new Violation.Customer("Customer", "Number 1,", new Violation.Wallet(20));
            Violation.Paperboy Paperboy1 = new Violation.Paperboy(Customer1);
            Paperboy1.GetPayedByCustomer();

            Console.WriteLine("Customer2 Has 20 Dollar");
            Improved.Customer Customer2 = new Improved.Customer("Customner", "Number 2", new Improved.Wallet(20));
            Improved.Paperboy Payperboy2 = new Improved.Paperboy(Customer2);
            Payperboy2.GetPayedByCustomer();

            Console.ReadLine();
        }
    }
}