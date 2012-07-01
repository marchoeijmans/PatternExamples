using System;

namespace ObserverPattern  
{
    public class Archiver: IObserver
    {
        public Archiver() { }

        public void update(string operation, string record)
        {
            Console.WriteLine("The Archiver says operation: " + operation + " was performed on record: " + record);
        }
    }
}
