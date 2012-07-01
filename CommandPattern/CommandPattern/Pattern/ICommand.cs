namespace CommandPattern.Pattern
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
