
namespace FactoryPattern.GofFactory
{
    public class SecureConnectionFactory : ConnectionFactory
    {
        public override Connection createConnection(ConnectionType type)
        {
            if (type.Equals(ConnectionType.SecureOracle))
                return new SecureOracleConnection();
            if (type.Equals(ConnectionType.SecureSqlServer))
                return new SecureSqlServerConnection();
            else
                return new SecureMySqlConnection();
        }
    }
}
