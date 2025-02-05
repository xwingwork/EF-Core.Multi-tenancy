using Expansion.TenantAgency.MultiTenant;
using Microsoft.EntityFrameworkCore;

namespace Expansion.TenantAgency.ContextFactory;

internal class AgencyScopedFactory<TContext>(
    // DbContext pooling https://learn.microsoft.com/en-us/ef/core/performance/advanced-performance-topics?tabs=with-di%2Cexpression-api-with-constant#dbcontext-pooling
    IDbContextFactory<TContext> pooledFactory,
    StoreConnection storeConnection) : IDbContextFactory<TContext> where TContext : DbContext
{
    private readonly IDbContextFactory<TContext> pooledFactory = pooledFactory ?? throw new ArgumentNullException(nameof(pooledFactory));
    private readonly StoreConnection storeConnection = storeConnection;

    public TContext CreateDbContext()
    {
        var dbContext = pooledFactory.CreateDbContext();

        // SetConnectionString <- Microsoft.EntityFrameworkCore.Relational
        dbContext.Database.SetConnectionString(storeConnection.GetSqlConnectionString()); // https://learn.microsoft.com/en-us/ef/core/miscellaneous/multitenancy
        return dbContext;
    }

    // CreateDbContextAsync不適用DI來建立，物件型別無法對應(Task<TContext> vs TContext)。且工廠下使用會可能性導致死結 https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines#async-di-factories-can-cause-deadlocks
    public async ValueTask<TContext> CreateDbContextAsync(CancellationToken cancellationToken = default)
    {
        var dbContext = await pooledFactory.CreateDbContextAsync(cancellationToken);
        dbContext.Database.SetConnectionString(storeConnection.GetSqlConnectionString());
        return dbContext;
    }
}
