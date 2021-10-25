using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.ConfigureKestrel(serverOptions =>
                   {
                       serverOptions.Listen(System.Net.IPAddress.Any, Convert.ToInt32(Environment.GetEnvironmentVariable("PORT")));
                   }).UseStartup<Startup>();
                   //webBuilder.UseStartup<Startup>();
               });
    }
}
