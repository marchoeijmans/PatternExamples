using System;

using MediatorPattern.Pattern;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            mediator.GetWelcome().Go();

            Console.ReadLine();
        }
    }
}
