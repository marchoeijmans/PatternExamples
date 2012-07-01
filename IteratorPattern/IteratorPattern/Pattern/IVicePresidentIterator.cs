namespace IteratorPattern.Pattern
{
    public interface IVicePresidentIterator
    {
        VicePresident Next();

        bool HasNext();

        void Remove();
    }
}
