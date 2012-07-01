namespace StatePattern.Pattern.AfterRefactor
{
    public class ApartmentRentedState : IState
    {
        private IAutomat automat;

        public ApartmentRentedState(IAutomat automat)
        {
            this.automat = automat;
        }

        public string GotApplication()
        {
            return "Hang on, we’re renting you an apartment.";
        }

        public string CheckApplication()
        {
            return "Hang on, we’re renting you an apartment.";
        }

        public string RentApartment()
        {
            this.automat.SetCount(this.automat.GetCount() - 1);
            return "Renting you an apartment....";
        }

        public string DispenseKeys()
        {
            if (this.automat.GetCount() <= 0)
            {
                this.automat.SetState(this.automat.GetFullyRentedState());
            }
            else
            {
                this.automat.SetState(this.automat.GetWaitingState());
            }

            return "Here are your keys!";
        }
    }
}
