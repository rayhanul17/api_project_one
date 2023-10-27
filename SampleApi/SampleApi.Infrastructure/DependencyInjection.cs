using Microsoft.Extensions.DependencyInjection;
using SampleApi.Application.Common.Interfaces.Authentication;
using SampleApi.Application.Common.Interfaces.Services;
using SampleApi.Infrastructure.Authentication;
using SampleApi.Infrastructure.Services;

namespace SampleApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}