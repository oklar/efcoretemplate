using MemberPlatform.DataAccess;

namespace MemberPlatform;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddDbContext<MemberDbContext>();
        return services;
    }
}
