using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLayer.BLL.Services;
using NLayer.DAL.DataContext;
using NLayer.DAL.Repositories;
using NLayer.DAL.Repositories.Base;

namespace NLayer.Root
{
    public class CompositionRoot
    {
        public static IServiceCollection AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDbContext, ApplicationDbContext>();
            return services;
        }

        public static IServiceCollection InjectDependencies(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IDataRepository, DataRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IDataService, DataService>();

            return services;
        }
    }
}
