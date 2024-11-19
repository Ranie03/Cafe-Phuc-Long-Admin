using BLL.Services;
using BLL.Services.Category;
using DAL.Repositories.Category;
using DAL.Repositories.Product;
using GUI.Forms.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace GUI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
        }
        public static void AddForms(this IServiceCollection services)
        {
            // Đăng ký form frmLogin vào DI container
            services.AddTransient<frmLogin>();

            services.AddTransient<frmMainManagement>();
            services.AddTransient<frmProductManagement>();
        }
    }
}
