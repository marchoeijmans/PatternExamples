using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverExample
{
    public interface IObserver
    {
        void Update(object newData);
    }
}
