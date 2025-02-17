using CRUDTestTask.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CRUDTestTask.Services;
using Microsoft.Extensions.Configuration;

namespace CRUDTestTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args)
                              .ConfigureServices((context, services) =>
        {
          var configuration  = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
            var dataProvider = configuration["DataProvider"];

          switch (dataProvider)
          {
              case "RuntimeMemory":
                  services.AddSingleton<IUserRepository, RuntimeMemoryUserRepository>();
                  break;
              case "Xml":
                  services.AddSingleton<IUserRepository, XmlUserRepository>(sp => new XmlUserRepository("users.xml"));
                  break;
              default:
                    services.AddSingleton<IUserRepository, RuntimeMemoryUserRepository>();
                    break;
            }

          services.AddSingleton<UserService>();
          services.AddSingleton<CrudViewerForm>();
      })
      .Build();

            var mainForm = builder.Services.GetRequiredService<CrudViewerForm>();
            Application.Run(mainForm);
        }

    }
}