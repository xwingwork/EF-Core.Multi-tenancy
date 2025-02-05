using Microsoft.Extensions.Configuration;

namespace Expansion.TenantAgency.MultiTenant;

// 資料庫複合使用情境分析，說明微軟為何不建議使用多租戶多儲存庫，https://daily.dev/blog/multi-tenant-database-design-patterns-2024
internal class StoreConnection(Tenant tenant, IConfiguration configuration)
{
    private readonly Tenant tenant = tenant;
    private readonly IConfiguration configuration = configuration;

    // TODO 從記憶體中，取得SqlConnectionString。源頭位於資料庫
    // TODO 初始化時使用，tenant會null，導致無法建置。
    // A：考慮預設值為Null的處理，驗證後面再做
    // B：開發環境的整合資訊，藉由外界給予，或是使用背景服務時做，避免在啟動程序中使用(本例實踐)
    public string? GetSqlConnectionString()
        => tenant.IsNull!
            // 從組態檔建置連接字串 https://learn.microsoft.com/zh-tw/sql/connect/ado-net/connection-string-builders?view=sql-server-ver16
            ? configuration.GetConnectionString(tenant.TenantId!)
            : throw new ArgumentNullException(nameof(tenant));
    /* TODO 連線字串檢查，非必要
     * 仿真整合環境的連線字串(Aspire編排框架給的、確認可使用給的)會判斷錯誤 SqlConnectionStringBuilder <- Microsoft.Data.SqlClient
     * 範例：new SqlConnectionStringBuilder(configuration.GetConnectionString(tenant.TenantId!)).ConnectionString  
     */
}
