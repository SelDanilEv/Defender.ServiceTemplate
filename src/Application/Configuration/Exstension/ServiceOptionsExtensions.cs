using Rentel.ServiceTemplate.Application.Configuration.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Rentel.ServiceTemplate.Application.Configuration.Exstension;

public static class ServiceOptionsExtensions
{
    public static IServiceCollection AddApplicationOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbOption>(configuration.GetSection(nameof(MongoDbOption)));

        services.Configure<UserManagementOption>(configuration.GetSection(nameof(UserManagementOption)));

        services.Configure<SampleOption>(configuration.GetSection(nameof(SampleOption)));

        return services;
    }
}