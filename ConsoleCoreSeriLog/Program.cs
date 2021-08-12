using System;
using Serilog;

namespace ConsoleCoreSeriLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            Log.Information("Usando o Serilog...");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Usando o Serilog");
            Console.ReadKey();
        }
    }
}
