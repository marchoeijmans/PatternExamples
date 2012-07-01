namespace StatePattern.Pattern.AfterRefactor
{
    public interface IAutomat
    {
        void GotApplication();

        void CheckApplication();

        void RentApartment();

        void SetState(IState state);

        IState GetWaitingState();

        IState GetGotApplicationState();

        IState GetApartmentRentedState();

        IState GetFullyRentedState();

        int GetCount();

        void SetCount(int count);
    }
}
