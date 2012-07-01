using System.Collections.Generic;

namespace ObserverPattern
{
    public class Database: ISubject
    {
        private List<IObserver> _observers;
        private string _operation;
        private string _record;

        public Database()
        {
            _observers = new List<IObserver>();
        }

        public void registerObserver(IObserver observerToRegister)
        {
            _observers.Add(observerToRegister);
        }

        public void unRegiserObserver(IObserver observerToUnRegister)
        {
            _observers.Remove(observerToUnRegister);
        }

        public void nofityObservers()
        {
            foreach (IObserver observerToNotify in _observers)
            {
                observerToNotify.update(_operation, _record);
            }
        }

        public void editRecord(string operation, string record)
        {
            this._operation = operation;
            this._record = record;
            nofityObservers();
        }
    }
}
