using System;

namespace CommandPattern.Pattern
{
    public class USServer : IReceiver
    {
        public USServer()
        {
        }

        public void Connect()
        {
            Console.WriteLine("You’re connected to the US server.");
        }

        public void Diagnostics()
        {
            Console.WriteLine("The US server diagnostics check out OK.");
        }

        public void Reboot()
        {
            Console.WriteLine("Rebooting the US server.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down the US server.");
        }

        public void Disconnect()
        {
            Console.WriteLine("You’re disconnected from the US server.");
        }
    }
}
