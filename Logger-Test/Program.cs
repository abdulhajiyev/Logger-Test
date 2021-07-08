using System;
using Serilog;
using Serilog.Events;

namespace Logger_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.File("log.txt")
                .CreateLogger();
            Console.WriteLine("Hello World!");
            log.Information("Test");
            log.Warning("Test");
            log.Error("Test");
            log.Fatal("Test");
        }
    }
}