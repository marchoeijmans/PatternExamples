namespace CommandPattern.Pattern
{
    public class Invoker
    {
        private ICommand[] commands = new ICommand[5];
        private int position;

        public Invoker()
        {
            this.position = -1;
        }

        public void SetCommand(ICommand command)
        {
            if (this.position < this.commands.Length - 1)
            {
                this.position++;
                this.commands[this.position] = command;
            }
            else
            {
                for (int loopIndex = 0; loopIndex < this.commands.Length - 2; loopIndex++)
                {
                    this.commands[loopIndex] = this.commands[loopIndex + 1];
                }

                this.commands[this.commands.Length - 1] = command;
            }
        }

        public void Run()
        {
            this.commands[this.position].Execute();
        }

        public void Undo()
        {
            if (this.position >= 0)
            {
                this.commands[this.position].Undo();
            }

            this.position--;
        }
    }
}
