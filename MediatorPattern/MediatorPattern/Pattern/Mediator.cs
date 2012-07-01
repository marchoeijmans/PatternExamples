namespace MediatorPattern.Pattern
{
    public class Mediator
    {
        private Welcome welcome;
        private Shop shop;
        private Purchase purchase;
        private Exit exit;

        public Mediator()
        {
            this.welcome = new Welcome(this);
            this.shop = new Shop(this);
            this.purchase = new Purchase(this);
            this.exit = new Exit(this);
        }

        public void Handle(string state)
        {
            if (state.Equals("welcome.shop"))
            {
                this.shop.Go();
            }
            else if (state.Equals("shop.purchase"))
            {
                this.purchase.Go();
            }
            else if (state.Equals("purchase.exit"))
            {
                this.exit.Go();
            }
            else if (state.Equals("welcome.exit"))
            {
                this.exit.Go();
            }
            else if (state.Equals("shop.exit"))
            {
                this.exit.Go();
            }
            else if (state.Equals("purchase.exit"))
            {
                this.exit.Go();
            }
        }

        public Welcome GetWelcome()
        {
            return this.welcome;
        }
    }
}
