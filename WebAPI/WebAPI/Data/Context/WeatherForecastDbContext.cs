using Microsoft.EntityFrameworkCore;
using WebAPI.Data.Model;

namespace WebAPI.Data.Context;

public partial class WeatherForecastDbContext : DbContext
{
    public WeatherForecastDbContext()
    {
    }

    public WeatherForecastDbContext(DbContextOptions<WeatherForecastDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<hr010> hr010s { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<hr010>(entity =>
        {
            entity.HasKey(e => new { e.comps, e.comp, e.orgmark, e.unino }).HasName("hr010_pkey");

            entity.Property(e => e.comps)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.comp)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.orgmark).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.unino)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.account).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adcity).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adcity2).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adcity2_tax).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adcity_tax).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adother).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adother2).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adother2_tax).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adother_tax).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.adzip)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.adzip_tax)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.app_service_uuid)
                .HasDefaultValueSql("''::character(1)")
                .IsFixedLength();
            entity.Property(e => e.bank).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.comp_en).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.comp_name).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.comp_name_short).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.date_cret)
                .HasDefaultValueSql("to_char(now(), 'YYYYMMDD'::text)")
                .IsFixedLength();
            entity.Property(e => e.date_modi)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.date_tran)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.dt_start)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.dt_stop)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.email).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.empname_tax).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.empno_cret)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.empno_modi)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.empno_tran)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.fiorg)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.fiorg1)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.heano)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.heano_ar)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.insno)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.labno)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.lang).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.org_empname).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.phone).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.phone_fax).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.stype3).HasDefaultValueSql("''::character(1)");
            entity.Property(e => e.taxid)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.taxid2)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.time_cret)
                .HasDefaultValueSql("to_char(now(), 'HH24MISS'::text)")
                .IsFixedLength();
            entity.Property(e => e.time_modi)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.time_tran)
                .HasDefaultValueSql("''::bpchar")
                .IsFixedLength();
            entity.Property(e => e.title).HasDefaultValueSql("''::bpchar");
            entity.Property(e => e.website).HasDefaultValueSql("''::bpchar");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
