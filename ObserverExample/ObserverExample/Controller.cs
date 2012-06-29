using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverExample
{
    public class Controller: ISubject
    {
        public InstanceUpgrader instanceUpgrader;

        public Controller()
        {
            this.instanceUpgrader = new InstanceUpgrader();
            this.observers = new List<IObserver>();
        }

        public void DoIt(string tekst)
        {
            string result = this.instanceUpgrader.Upgrade(tekst);
            this.NofityObservers(result);
        }

        private List<IObserver> observers;


        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void UnRegiserObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NofityObservers(object newData)
        {
            foreach (IObserver observerToNotify in this.observers)
            {
                observerToNotify.Update(newData);
            }
        }
    }
}
