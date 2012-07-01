using System;

namespace StatePattern.Pattern.AfterRefactor
{
    public class GotApplicationState : IState
    {
        private IAutomat automat;
        private Random random;

        public GotApplicationState(IAutomat automat)
        {
            this.automat = automat;
            this.random = new Random(System.DateTime.Now.TimeOfDay.Milliseconds);
        }

        public string GotApplication()
        {
            return "We already got your application.";
        }

        public string CheckApplication()
        {
            int yesno = this.random.Next(100) % 10;

            if (yesno > 4 && this.automat.GetCount() > 0)
            {
                this.automat.SetState(this.automat.GetApartmentRentedState());
                return "Congratulations, you were approved.";
            }
            else
            {
                this.automat.SetState(this.automat.GetWaitingState());
                return "Sorry, you were not approved.";
            }
        }

        public string RentApartment()
        {
            return "You must have your application checked.";
        }

        public string DispenseKeys()
        {
            return "You must have your application checked.";
        }
    }
}
