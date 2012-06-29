using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverExample
{
    public interface ISubject
    {
        /// <summary>
        /// Register an observer
        /// </summary>
        /// <param name="observer">the observer to register</param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// Un register an observer
        /// </summary>
        /// <param name="observer">The observer to un register.</param>
        void UnRegiserObserver(IObserver observer);

        /// <summary>
        /// Notify all registered observers
        /// </summary>
        /// <param name="newData">The new data.</param>
        void NofityObservers(object newData);
    }
}
