using System;

using BridgePattern.Pattern;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Abstraction abstractionA = new Abstraction(new ImplementationA());
            Console.WriteLine(abstractionA.Operation());

            Abstraction abstractionB = new Abstraction(new ImplementationB());
            Console.WriteLine(abstractionB.Operation());

            Console.ReadLine();
        }
    }
}
