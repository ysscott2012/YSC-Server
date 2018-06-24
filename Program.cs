using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace YSC_Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // find a logs folder
            var logsDir = Path.Combine(Directory.GetCurrentDirectory(), "logs");
            // Create a logs folder if it doesn't exist.
            Directory.CreateDirectory(logsDir);
            var host = BuildWebHost(args);
            host.Run();
        }

        private static IWebHost BuildWebHost(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();
            var config = builder.Build();
            return WebHost.CreateDefaultBuilder(args)
                .UseKestrel(opt =>
                {
                    if (!int.TryParse(config["Port"], out var port))
                    {
                        port = 5000;
                    }

                    opt.Listen(IPAddress.Any, port);
                })
                .UseStartup<Startup>()
                .ConfigureLogging((context, logging) =>
                    {
                        logging.AddConfiguration(context.Configuration.GetSection("Logging"));
                        logging.SetMinimumLevel(LogLevel.Debug);
                        logging.AddDebug();
                    })
                .Build();
        }
    }
}
