
namespace FactoryPattern.GofFactory
{
    public class UnSecureConnectionFactory : ConnectionFactory
    {
        public override Connection createConnection(ConnectionType type)
        {
            if (type.Equals(ConnectionType.Oracle))
                return new OracleConnection();
            if (type.Equals(ConnectionType.SqlServer))
                return new SqlServerConnection();
            else
                return new MySqlConnection();
        }
    }
}
