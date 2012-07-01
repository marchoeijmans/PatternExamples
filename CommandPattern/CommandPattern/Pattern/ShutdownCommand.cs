using System;

namespace CommandPattern.Pattern
{
    public class ShutdownCommand : ICommand
    {
        private IReceiver receiver;

        public ShutdownCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.Connect();
            this.receiver.Shutdown();
            this.receiver.Disconnect();
            Console.WriteLine();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing...");
            this.receiver.Connect();
            this.receiver.Reboot();
            this.receiver.Disconnect();
            Console.WriteLine();
        }
    }
}
