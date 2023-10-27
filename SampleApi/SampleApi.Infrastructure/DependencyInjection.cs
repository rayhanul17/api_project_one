using Microsoft.Extensions.DependencyInjection;
using SampleApi.Application.Common.Interfaces.Authentication;
using SampleApi.Infrastructure.Authentication;

namespace SampleApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}