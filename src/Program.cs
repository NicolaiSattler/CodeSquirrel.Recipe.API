﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CodeSquirrel.RecipeApp.API
{
    public class Program
    {
        protected Program()
        {

        }

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                          .UseStartup<Startup>()
                          .Build();
        }
    }
}
