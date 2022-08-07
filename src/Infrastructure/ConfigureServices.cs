using System.Reflection;
using Defender.ServiceTemplate.Application.Common.Interfaces;
using Defender.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Defender.ServiceTemplate.Application.Configuration.Options;
using Defender.ServiceTemplate.Infrastructure.Clients;
using Defender.ServiceTemplate.Infrastructure.Clients.Interfaces;
using Defender.ServiceTemplate.Infrastructure.Clients.UserManagement;
using Defender.ServiceTemplate.Infrastructure.Repositories.Sample;
using Defender.ServiceTemplate.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Defender.ServiceTemplate.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddTransient<IAuthService, AuthService>();
        services.AddTransient<ISampleService, SampleService>();

        services.AddTransient<ISampleRepository, SampleRepository>();

        RegisterApiClients(services);

        return services;
    }

    private static void RegisterApiClients(IServiceCollection services)
    {
        services.AddHttpClient<ISampleClient, SampleClient>("SampleClient", (serviceProvider, client) =>
        {
            client.BaseAddress = new Uri(serviceProvider.GetRequiredService<IOptions<SampleOption>>().Value.Url);
        });

        services.AddHttpClient<IUserManagementClient, UserManagementClient>("UserManagementClient", (serviceProvider, client) =>
        {
            client.BaseAddress = new Uri(serviceProvider.GetRequiredService<IOptions<UserManagementOption>>().Value.Url);
        });
    }

}
