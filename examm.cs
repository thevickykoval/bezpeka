using System;
using Microsoft.Extensions.Logging;

namespace С_
{
    class Program
    {
        static void Main(string[] args)
    {

        var loggerFactory = LoggerFactory.Create(builder =>
       {
           builder
                .AddFilter("Microsoft", Microsoft.Extensions.Logging.LogLevel.Warning)
                .AddFilter("System", Microsoft.Extensions.Logging.LogLevel.Warning)
                builder.AddConsole()
                .AddEventLog()
                .AddDebug();
       });
        Microsoft.Extensions.Logging.ILogger logger = loggerFactory.CreateLogger<Program>();
        logger.LogCritical(1, "The Example LogCritical ({0}).", DateTime.UtcNow);
        logger.LogError(2, "The Example LogError ({0}).", DateTime.UtcNow);
        logger.LogWarning(3, "The Example Warning ({0}).", DateTime.UtcNow);
    }
    }
}