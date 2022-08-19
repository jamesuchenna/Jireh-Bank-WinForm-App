using Core.Interface;
using Core.Services;
using Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace JirehBankUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Welcome());
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Welcome>();
                Application.Run(form1);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IAuthentification, Authentification>();
            services.AddScoped<IValidate, Validate>();
            services.AddScoped<ICustomerServices, CustomerServices>();
            services.AddScoped<IAccountServices, AccountServices>();
            services.AddScoped<Welcome>();
            services.AddTransient<Registration>();
            services.AddTransient<DashBoardN>();
        }




    }
}