using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleApi.Application.Common.Interfaces.Authentication;
using SampleApi.Application.Common.Interfaces.Persistance;
using SampleApi.Application.Common.Interfaces.Services;
using SampleApi.Infrastructure.Authentication;
using SampleApi.Infrastructure.Persistance;
using SampleApi.Infrastructure.Services;

namespace SampleApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                       ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}