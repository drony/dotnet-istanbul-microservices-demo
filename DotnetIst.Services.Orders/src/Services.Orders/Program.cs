﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Shared.Logging;

namespace Services.Orders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseLogging("Order.Service");
    }
}
