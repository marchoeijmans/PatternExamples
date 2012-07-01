using System;

namespace StatePattern.Pattern.AfterRefactor
{
    public class Automat : IAutomat
    {
        private IState waitingState;
        private IState gotApplicationState;
        private IState apartmentRentedState;
        private IState fullyRentedState;
        private IState currentState;
        private int numberOfAvailableApartments;

        public Automat(int numberOfAvailableApartments)
        {
            this.numberOfAvailableApartments = numberOfAvailableApartments;

            this.waitingState = new WaitingState(this);
            this.gotApplicationState = new GotApplicationState(this);
            this.apartmentRentedState = new ApartmentRentedState(this);
            this.waitingState = new WaitingState(this);
            this.fullyRentedState = new FullyRentedState(this);

            this.currentState = this.waitingState;
        }

        public void GotApplication()
        {
            Console.WriteLine(this.currentState.GotApplication());
        }

        public void CheckApplication()
        {
            Console.WriteLine(this.currentState.CheckApplication());
        }

        public void RentApartment()
        {
            Console.WriteLine(this.currentState.RentApartment());
            Console.WriteLine(this.currentState.DispenseKeys());
        }

        public void SetState(IState state)
        {
            this.currentState = state;
        }

        public IState GetWaitingState()
        {
            return this.waitingState;
        }

        public IState GetGotApplicationState()
        {
            return this.gotApplicationState;
        }

        public IState GetApartmentRentedState()
        {
            return this.apartmentRentedState;
        }

        public IState GetFullyRentedState()
        {
            return this.fullyRentedState;
        }

        public int GetCount()
        {
            return this.numberOfAvailableApartments;
        }

        public void SetCount(int numberOfAvailableApartments)
        {
            this.numberOfAvailableApartments = numberOfAvailableApartments;
        }
    }
}
