using System.Net.Http.Headers;
using System.Reflection;
using Rentel.ServiceTemplate.Application.Common.Interfaces;
using Rentel.ServiceTemplate.Application.Common.Interfaces.Repositories;
using Rentel.ServiceTemplate.Application.Configuration.Options;
using Rentel.ServiceTemplate.Infrastructure.Clients;
using Rentel.ServiceTemplate.Infrastructure.Clients.Interfaces;
using Rentel.ServiceTemplate.Infrastructure.Clients.UserManagement;
using Rentel.ServiceTemplate.Infrastructure.Repositories.Sample;
using Rentel.ServiceTemplate.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Rentel.ServiceTemplate.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.RegisterServices();

        services.RegisterRepositories();

        services.RegisterApiClients();

        return services;
    }

    private static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddTransient<IAuthService, AuthService>();
        services.AddTransient<IAccountManagementService, AccountManagementService>();
        services.AddTransient<ISampleService, SampleService>();

        return services;
    }

    private static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddTransient<ISampleRepository, SampleRepository>();

        return services;
    }

    private static IServiceCollection RegisterApiClients(
        this IServiceCollection services)
    {
        services.AddHttpClient<ISampleClient, SampleClient>("SampleClient",
            (serviceProvider, client) =>
        {
            client.BaseAddress = new Uri(
                serviceProvider.GetRequiredService<IOptions<SampleOption>>().Value.Url);
        });

        services.AddHttpClient<IUserManagementClient, UserManagementClient>("UserManagementClient",
            (serviceProvider, client) =>
        {
            client.BaseAddress = new Uri(
                serviceProvider.GetRequiredService<IOptions<UserManagementOption>>().Value.Url);

            var token = serviceProvider.GetRequiredService<ICurrentUserAccessor>().Token;

            if (!string.IsNullOrWhiteSpace(token))
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(token);
            }
        });

        return services;
    }

}
