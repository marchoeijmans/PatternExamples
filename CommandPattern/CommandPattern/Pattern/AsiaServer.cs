using System;

namespace CommandPattern.Pattern
{
    public class AsiaServer : IReceiver
    {
        public AsiaServer()
        {
        }

        public void Connect()
        {
            Console.WriteLine("You’re connected to the Asia server.");
        }

        public void Diagnostics()
        {
            Console.WriteLine("The Asia server diagnostics check out OK.");
        }

        public void Reboot()
        {
            Console.WriteLine("Rebooting the Asia server.");
        }

        public void Shutdown()
        {
            Console.WriteLine("Shutting down the Asia server.");
        }

        public void Disconnect()
        {
            Console.WriteLine("You’re disconnected from the Asia server.");
        }
    }
}
