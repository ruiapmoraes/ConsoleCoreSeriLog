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
            //Console.ReadKey();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs\\meuLoggerApp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Olá Serilog");

            int a = 10, b = 0;
            try
            {
                Log.Debug($"Dividindo {a} por {b}.");
                Console.WriteLine(a/b);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Alguma coisa deu errado...");
            }

            Log.CloseAndFlush();
            Console.ReadKey();
                
        }
    }
}
