using System;

using CommandPattern.Pattern;

namespace CommandPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            AsiaServer asiaServer = new AsiaServer();
            EuroServer euroServer = new EuroServer();
            USServer unitedStatesServer = new USServer();

            ShutdownCommand shutDownAsia = new ShutdownCommand(asiaServer);
            RunDiagnosticsCommand runDiagnosticsAsia = new
            RunDiagnosticsCommand(asiaServer);
            RebootCommand rebootAsia = new RebootCommand(asiaServer);

            invoker.SetCommand(shutDownAsia);
            invoker.Run();

            invoker.SetCommand(rebootAsia);
            invoker.Run();

            invoker.Undo();
            invoker.Undo();

            invoker.SetCommand(runDiagnosticsAsia);
            invoker.Run();

            ShutdownCommand shutDownEuro = new ShutdownCommand(euroServer);
            RunDiagnosticsCommand runDiagnosticsEuro = new
            RunDiagnosticsCommand(euroServer);
            RebootCommand rebootEuro = new RebootCommand(euroServer);

            invoker.SetCommand(shutDownEuro);
            invoker.Run();

            invoker.SetCommand(rebootEuro);
            invoker.Run();

            invoker.SetCommand(runDiagnosticsEuro);
            invoker.Run();

            ShutdownCommand shutDownUS = new ShutdownCommand(unitedStatesServer);
            RunDiagnosticsCommand runDiagnosticsUS = new
            RunDiagnosticsCommand(unitedStatesServer);
            RebootCommand rebootUS = new RebootCommand(unitedStatesServer);

            invoker.SetCommand(shutDownUS);
            invoker.Run();

            invoker.SetCommand(rebootUS);
            invoker.Run();

            invoker.SetCommand(runDiagnosticsUS);
            invoker.Run();

            Console.ReadLine();
        }
    }
}
