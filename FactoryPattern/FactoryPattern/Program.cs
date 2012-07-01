using System;
using GOF = FactoryPattern.GofFactory;
using NORML = FactoryPattern.NormalFactory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NORML.ConnectionFactory factory = new NORML.ConnectionFactory(NORML.ConnectionType.SqlServer);
            NORML.Connection sqlConnection = factory.createConnection();

            Console.WriteLine(sqlConnection.open());
            Console.WriteLine(sqlConnection.close());

            factory = new NORML.ConnectionFactory(NORML.ConnectionType.MySql);
            NORML.Connection mySqlConnection = factory.createConnection();
            Console.WriteLine(mySqlConnection.open());
            Console.WriteLine(mySqlConnection.close());

            factory = new NORML.ConnectionFactory(NORML.ConnectionType.Oracle);
            NORML.Connection oracleConnection = factory.createConnection();
            Console.WriteLine(oracleConnection.open());
            Console.WriteLine(oracleConnection.close());

            Console.WriteLine("--------------------------");

            GOF.SecureConnectionFactory secureFactory = new GOF.SecureConnectionFactory();
            GOF.Connection secureSqlServerConnection = secureFactory.createConnection(GOF.ConnectionType.SecureSqlServer);
            Console.WriteLine(secureSqlServerConnection.open());
            Console.WriteLine(secureSqlServerConnection.close());

            GOF.Connection secureMySqlConnection = secureFactory.createConnection(GOF.ConnectionType.SecureMySql);
            Console.WriteLine(secureMySqlConnection.open());
            Console.WriteLine(secureMySqlConnection.close());

            GOF.Connection secureOracleConnection = secureFactory.createConnection(GOF.ConnectionType.SecureOracle);
            Console.WriteLine(secureOracleConnection.open());
            Console.WriteLine(secureOracleConnection.close());

            Console.WriteLine("--------------------------");

            GOF.UnSecureConnectionFactory unSecureFactory = new GOF.UnSecureConnectionFactory();
            GOF.Connection unSecureSqlServerConnection = unSecureFactory.createConnection(GOF.ConnectionType.SqlServer);
            Console.WriteLine(unSecureSqlServerConnection.open());
            Console.WriteLine(unSecureSqlServerConnection.close());

            GOF.Connection unSecureMySqlConnection = unSecureFactory.createConnection(GOF.ConnectionType.MySql);
            Console.WriteLine(unSecureMySqlConnection.open());
            Console.WriteLine(unSecureMySqlConnection.close());

            GOF.Connection unSecureOracleConnection = unSecureFactory.createConnection(GOF.ConnectionType.Oracle);
            Console.WriteLine(unSecureOracleConnection.open());
            Console.WriteLine(unSecureOracleConnection.close());


            Console.ReadLine();
        }
    }
}