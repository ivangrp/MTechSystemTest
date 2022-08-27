using Employees.Application.Common.Interfaces;
using Employees.Infraestructure.Persistence;
using Employees.Infraestructure.Repository.Command;
using Employees.Infraestructure.Repository.Command.Base;
using Employees.Infraestructure.Repository.Query;
using Employees.Infraestructure.Repository.Query.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Employees.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure for Sqlite
            services.AddDbContext<EmployeeContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
            services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
            
            services.AddTransient<IEmployeeQueryRepository, EmployeeQueryRepository>();
            services.AddTransient<IEmployeeCommandRepository, EmployeeCommandRepository>();
            
            return services;
        }
    }
}
