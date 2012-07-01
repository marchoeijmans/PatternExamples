namespace CommandPattern.Pattern
{
    public interface IReceiver
    {
        void Connect();

        void Diagnostics();

        void Reboot();

        void Shutdown();

        void Disconnect();
    }
}
