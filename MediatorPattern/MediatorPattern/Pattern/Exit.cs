using System;

namespace MediatorPattern.Pattern
{
    public class Exit
    {
        private Mediator mediator;

        public Exit(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine("Please come again sometime.");
        }
    }
}
