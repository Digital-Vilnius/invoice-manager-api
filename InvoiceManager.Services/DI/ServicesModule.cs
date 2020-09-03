using AutoMapper;
using InvoiceManager.Models.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceManager.Services.DI
{
    public class ServicesModule
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServicesModule));

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IEncryptionService, EncryptionService>();
            services.AddScoped<IFileService, FileService>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IClientService, ClientService>();
        }
    }
}