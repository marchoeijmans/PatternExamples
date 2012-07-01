namespace StatePattern.Pattern.AfterRefactor
{
    public class WaitingState : IState
    {
        private IAutomat automat;

        public WaitingState(IAutomat automat)
        {
            this.automat = automat;
        }

        public string GotApplication()
        {
            this.automat.SetState(this.automat.GetGotApplicationState());
            return "Thanks for the application.";
        }

        public string CheckApplication()
        {
            return "You have to submit an application.";
        }

        public string RentApartment()
        {
            return "You have to submit an application.";
        }

        public string DispenseKeys()
        {
            return "You have to submit an application.";
        }
    }
}
