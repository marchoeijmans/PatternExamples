using System;

namespace ObserverPattern
{
    public class Boss: IObserver
    {
        public Boss() { }

        public void update(string operation, string record)
        {
            Console.WriteLine("The Boss says operation: " + operation + " was performed on record: " + record);
        }
    }
}
