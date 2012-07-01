namespace StatePattern.Pattern.AfterRefactor
{
    public interface IState
    {
        string GotApplication();

        string CheckApplication();

        string RentApartment();

        string DispenseKeys();
    }
}
