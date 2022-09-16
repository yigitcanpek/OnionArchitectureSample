using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjection
{
    public static class RepManService
    {
        public static IServiceCollection AddRepManServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>),typeof(BaseRepository<>));
            services.AddScoped<IProductRep, ProductRepository>();
            services.AddScoped<ICategoryRep, CategoryRepository>();
            services.AddScoped<IOrderDetailRep, OrderDetailRepository>();
            services.AddScoped<IOrderRep, OrderRepository>();
            services.AddScoped<IAppUserRep, AppUserRepository>();
            services.AddScoped<IProfileRep, ProfileRepository>();

            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IOrderDetailManager, OrderDetailManager>();
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IProfileManager, ProfileManager>();

            return services;
        }
    }
}
