using System;

namespace CommandPattern.Pattern
{
    public class RunDiagnosticsCommand : ICommand
    {
        private IReceiver receiver;

        public RunDiagnosticsCommand(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            this.receiver.Connect();
            this.receiver.Diagnostics();
            this.receiver.Disconnect();
            Console.WriteLine();
        }

        public void Undo()
        {
            Console.WriteLine("Can't Undo.");
            Console.WriteLine();
        }
    }
}
