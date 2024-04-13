using Microsoft.Extensions.DependencyInjection;

namespace Yogurt.NET.AspNetCore;

public static class YogurtNetExtensions
{
    public static IServiceCollection AddYogurtNetService(this IServiceCollection services)
    {
        // services.TryAddSingleton<>();

        return services;
    }
}