

using CalculadoraDeEdadMVC.Controllers;
using Microsoft.Extensions.Configuration;

namespace CalculadoraDeEdadMVC
{
    public class Program
    {
       public static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string appName = configuration.GetSection("AppSettings:AppName").Value ?? "N/A"; 
            string author = configuration.GetSection("AppSettings:Author").Value ?? "N/A"; 
            string version = configuration.GetSection("AppSettings:Version").Value ?? "N/A";

            Console.WriteLine($"App Name: {appName}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Version: {version}");

            MenuController menuController = new MenuController(configuration);
            menuController.ManageMenu();
        }
    }  
}
