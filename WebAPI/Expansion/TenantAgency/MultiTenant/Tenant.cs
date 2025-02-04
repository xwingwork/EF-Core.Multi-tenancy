using System.Data.SqlTypes;

namespace Expansion.TenantAgency.MultiTenant;

public record Tenant : INullable
{
    public Tenant(string? tenantId)
        => TenantId = tenantId;

    public string? TenantId { get; }

    public bool IsNull => TenantId != null && TenantId != string.Empty;
}