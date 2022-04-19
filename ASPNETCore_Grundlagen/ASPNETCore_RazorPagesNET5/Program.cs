using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_RazorPagesNET5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Configuration von Serilog wurden eingelesen und 
            IHost host = CreateHostBuilder(args).Build();

            try
            {
                host.Run();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.ToString());
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
