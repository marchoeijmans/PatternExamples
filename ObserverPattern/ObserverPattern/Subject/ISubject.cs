
namespace ObserverPattern
{
    public interface ISubject
    {
        void registerObserver(IObserver observerToRegister);
        void unRegiserObserver(IObserver observerToUnRegister);
        void nofityObservers();
    }
}
