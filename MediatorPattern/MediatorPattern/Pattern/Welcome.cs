using System;

namespace MediatorPattern.Pattern
{
    public class Welcome
    {
        private Mediator mediator;
        private string response = "n";

        public Welcome(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Go()
        {
            Console.WriteLine("Do you want to shop? [y/n]? ");
            this.response = Console.ReadLine();

            if (this.response.Equals("y"))
            {
                this.mediator.Handle("welcome.shop");
            }
            else
            {
                this.mediator.Handle("welcome.exit");
            }
        }
    }
}
