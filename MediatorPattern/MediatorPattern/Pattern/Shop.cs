using System;

namespace MediatorPattern.Pattern
{
    public class Shop
    {
        private Mediator mediator;
        private string response = "n";

        public Shop(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine("Are you ready to purchase? [y/n]? ");
            this.response = Console.ReadLine();

            if (this.response.Equals("y"))
            {
                this.mediator.Handle("shop.purchase");
            }
            else
            {
                this.mediator.Handle("shop.exit");
            }
        }
    }
}
