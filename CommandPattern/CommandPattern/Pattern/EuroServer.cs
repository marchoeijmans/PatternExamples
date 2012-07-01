using System;

namespace CommandPattern.Pattern
{
    public class EuroServer : IReceiver
    {
        public EuroServer()
        {
        }

        public void Connect()
        {
            Console.WriteLine("You’re connected to the European server.");
        }

        public void Diagnostics()
        {
            Console.WriteLine("The European server diagnostics check out OK.");
        }

        public void Reboot()
        {
            Console.WriteLine("Rebooting the European server.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down the European server.");
        }

        public void Disconnect()
        {
            Console.WriteLine("You’re disconnected from the European server.");
        }
    }
}
