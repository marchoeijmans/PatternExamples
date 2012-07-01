namespace StatePattern.Pattern.AfterRefactor
{
    public class FullyRentedState : IState
    {
        private IAutomat automat;

        public FullyRentedState(IAutomat automat)
        {
            this.automat = automat;
        }

        public string GotApplication()
        {
            return "Sorry, we’re fully rented.";
        }

        public string CheckApplication()
        {
            return "Sorry, we’re fully rented.";
        }

        public string RentApartment()
        {
            return "Sorry, we’re fully rented.";
        }

        public string DispenseKeys()
        {
            return "Sorry, we’re fully rented.";
        }
    }
}
