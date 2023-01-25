using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace AtrinGol.Contract.EntityFrameworkCore;

public class ContractHttpApiHostMigrationsDbContext : AbpDbContext<ContractHttpApiHostMigrationsDbContext>
{
    public ContractHttpApiHostMigrationsDbContext(DbContextOptions<ContractHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ConfigureContract();
        modelBuilder.ConfigureSettingManagement();
        modelBuilder.ConfigureAuditLogging();
        modelBuilder.ConfigureTenantManagement();
    }
}
