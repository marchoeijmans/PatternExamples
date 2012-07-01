using System;

namespace SingletonPattern.Pattern
{
    public sealed class Database
    {
        private static Database singleObject;
        private static object syncLock = new object();
        private int record;
        private string name;

        private Database(string name)
        {
            this.name = name;
            this.record = 0;
        }

        // singleton utility method
        // Support multithreaded applications through 'Double checked locking'            
        // pattern which (once the instance exists) avoids locking each time the method is invoked 
        public static Database GetInstance(string name)
        {
            if (singleObject == null)
            {
                lock (syncLock)
                {
                    if (singleObject == null)
                    {
                        singleObject = new Database(name);
                    }
                }
            }

            return singleObject;
        }

        public void EditRecord(string operation)
        {
            Console.WriteLine("Performing a " + operation + " operation on record " + this.record + " in database " + this.name);
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
