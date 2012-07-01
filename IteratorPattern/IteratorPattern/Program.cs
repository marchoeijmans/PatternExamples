using System;

using IteratorPattern.Pattern;

namespace IteratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalesDivision salesDivision = new SalesDivision("Sales department");
            salesDivision.Add("Ted");
            salesDivision.Add("Bob");
            salesDivision.Add("Carol");
            salesDivision.Add("Alice");

            IVicePresidentIterator vicePresidentsIterator = salesDivision.Iterator();

            while (vicePresidentsIterator.HasNext())
            {
                VicePresident vicePresident = vicePresidentsIterator.Next();
                vicePresident.Print();
            }

            Console.ReadLine();
        }
    }
}
