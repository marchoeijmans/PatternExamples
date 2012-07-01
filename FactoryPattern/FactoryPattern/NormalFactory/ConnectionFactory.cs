
namespace FactoryPattern.NormalFactory
{
    public class ConnectionFactory
    {
        private ConnectionType _type;

        public ConnectionFactory(ConnectionType type)
        {
            _type = type;
        }

        public Connection createConnection()
        {
            if (_type.Equals(ConnectionType.Oracle))
                return new OracleConnection();
            if (_type.Equals(ConnectionType.SqlServer))
                return new SqlServerConnection();
            else 
                return new MySqlConnection();
        }
    }
}
