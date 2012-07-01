using System;

namespace ObserverPattern
{
    public class Client: IObserver
    {
        public Client() { }


        public void update(string operation, string record)
        {
            Console.WriteLine("The Client says operation: " + operation + " was performed on record: " + record);
        }
    }
}
