using BLL.Services;
using BLL.Services.Category;
using BLL.Services.ProductDetail;
using BLL.Services.Recipe;
using BLL.Services.Size;
using DAL.Repositories.Category;
using DAL.Repositories.Product;
using DAL.Repositories.ProductDetail;
using DAL.Repositories.Recipe;
using DAL.Repositories.Size;
using GUI.Forms.Manager;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            services.AddTransient<IProductDetailRepository, ProductDetailRepository>();
            services.AddTransient<ISizeRepository, SizeRepository>();
            services.AddTransient<IRecipeRepository, RecipeRepository>();


        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductDetailService, ProductDetailService>();
            services.AddTransient<ISizeService, SizeService>();
            services.AddTransient<IRecipeService, RecipeService>();

        }
        public static void AddForms(this IServiceCollection services)
        {
            // Đăng ký form frmLogin vào DI container
            services.AddTransient<frmLogin>();

            services.AddTransient<frmMainManagement>();
            services.AddTransient<frmProductManagement>();
            services.AddTransient<frmMaterialManagement>();

        }
    }
}
