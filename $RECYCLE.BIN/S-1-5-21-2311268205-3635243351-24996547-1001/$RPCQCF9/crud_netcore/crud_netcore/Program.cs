using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_netcore.Mod;
using crud_netcore.ModelFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace crud_netcore
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            
            CreateHostBuilder(args).Build().Run();

          

            //var Result = from o in Persons
            //             join od in Addresses on o.Id equals od.Id
            //             select new { o.Name, od.City };

            //Result.Dump();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
