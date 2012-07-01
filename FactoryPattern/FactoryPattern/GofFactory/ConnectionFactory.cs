
namespace FactoryPattern.GofFactory
{
    public abstract class ConnectionFactory
    {
        public ConnectionFactory() { }

        public abstract Connection createConnection(ConnectionType type);
    }
}
