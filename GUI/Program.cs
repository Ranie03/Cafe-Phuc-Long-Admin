﻿using DTO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tạo và cấu hình IHostBuilder
            var host = CreateHostBuilder(args).Build();

            // Lấy đối tượng frmLogin từ DI container
            var frmLogin = host.Services.GetRequiredService<frmLogin>();

            Application.Run(frmLogin);
        }

        #region Cấu hình IHostBuilder

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    // Đăng ký DbContext với Connection String
                    services.AddTransient(provider =>
                    {
<<<<<<< Updated upstream
                        string connectionString = "Data Source=KAMLING;Initial Catalog=E-Commerce_Coffee_And_Tea;Integrated Security=True";
=======
                        string connectionString = "Data Source=MSI;Initial Catalog=E-Commerce_Coffee_And_Tea;Integrated Security=True;Encrypt=False";
>>>>>>> Stashed changes
                        return new E_Commerce_Coffee_And_TeaDataContext(connectionString);
                    });

                    services.AddRepositories();
                    services.AddServices();
                    services.AddForms();
                });
        }

        #endregion
    }
}
