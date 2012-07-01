using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Database databaseSubject = new Database();
            Archiver archiverObserver = new Archiver();
            Boss bossObserver = new Boss();
            Client clientObserver = new Client();

            databaseSubject.registerObserver(archiverObserver);
            databaseSubject.registerObserver(bossObserver);
            databaseSubject.registerObserver(clientObserver);

            databaseSubject.editRecord("edit", "record1");

            Console.ReadLine();
        }
    }
}
