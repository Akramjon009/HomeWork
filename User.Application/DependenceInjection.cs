using Microsoft.Extensions.DependencyInjection;
using OrderManagementAPI.Application.Abstractions.IService;
using OrderManagementAPI.Application.Abstractions.Service;

namespace OrderManagementAPI.Application
{
    public static class DependenceInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
