using Microsoft.Extensions.DependencyInjection;
using SampleApi.Application.Services.Authentication;

namespace SampleApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}