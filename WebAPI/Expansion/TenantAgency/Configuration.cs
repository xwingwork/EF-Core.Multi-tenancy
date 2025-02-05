using Expansion.TenantAgency.ContextFactory;
using Expansion.TenantAgency.MultiTenant;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Expansion.TenantAgency;

public static class Configuration
{
    public static IServiceCollection AddTenantAgencyService(
        this IServiceCollection services
        , string tenantKey = "TenantId")
        => services
            .AddHttpContextAccessor() // AddHttpContextAccessor <- Microsoft.AspNetCore.Http
            .AddScoped(sp =>
            {
                return sp.GetRequiredService<IHttpContextAccessor>().HttpContext?
                .Request.Headers.TryGetValue(tenantKey, out var tenantIdString) != null
                    ? new Tenant(tenantIdString.FirstOrDefault())
                    : new Tenant(null);
            })
            .AddScoped<StoreConnection>();

    public static IServiceCollection AddAgencyStoreFactoryService<TContext>(
         this IServiceCollection services
         , Action<DbContextOptionsBuilder> optionsAction)
         where TContext : DbContext
         => services
             .AddPooledDbContextFactory<TContext>(optionsAction)
             .AddScoped<AgencyScopedFactory<TContext>>()
             .AddScoped(sp =>
             sp.GetRequiredService<AgencyScopedFactory<TContext>>()
                .CreateDbContext());
}
