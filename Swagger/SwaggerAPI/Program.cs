using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SwaggerAPI
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
                    webBuilder.UseStartup<Startup>();
                });
    }
}

/*
 * Sites
 * https://www.youtube.com/watch?v=oAm_GTMLcng&ab_channel=DEVNETCOREValdirFerreira
 * https://www.youtube.com/watch?v=lrYElKHrGdY&ab_channel=Jo%C3%A3oPedroHudinik
*/