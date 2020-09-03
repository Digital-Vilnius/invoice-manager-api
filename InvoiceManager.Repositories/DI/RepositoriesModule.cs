using InvoiceManager.Models.Repositories;
using InvoiceManager.Repositories.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceManager.Repositories.DI
{
    public static class RepositoriesModule
    {
        public static void RegisterDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlContext")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        }
    }
}