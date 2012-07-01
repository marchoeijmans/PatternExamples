using System;

namespace MediatorPattern.Pattern
{
    public class Purchase
    {
        private Mediator mediator;
        private string response = "n";

        public Purchase(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine("Buy the item now? [y/n]? ");
            this.response = Console.ReadLine();

            if (this.response.Equals("y"))
            {
                Console.WriteLine("Thanks for your purchase.");
            }

            this.mediator.Handle("purchase.exit");
        }
    }
}
