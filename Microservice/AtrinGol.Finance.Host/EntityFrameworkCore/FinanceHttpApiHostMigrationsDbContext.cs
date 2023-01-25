using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace AtrinGol.Finance.EntityFrameworkCore;

public class FinanceHttpApiHostMigrationsDbContext : AbpDbContext<FinanceHttpApiHostMigrationsDbContext>
{
    public FinanceHttpApiHostMigrationsDbContext(DbContextOptions<FinanceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ConfigureFinance();
        modelBuilder.ConfigureSettingManagement();
        modelBuilder.ConfigureAuditLogging();
        modelBuilder.ConfigureTenantManagement();
    }
}
