using Microsoft.EntityFrameworkCore;
using ProjetoLutaOficial;

using ProjetoLutaOficial.Repositories;
using ProjetoLutaOficial.Repositories.Interface;



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

