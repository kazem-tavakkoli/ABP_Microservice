using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AtrinGol.Contract.EntityFrameworkCore;

[ConnectionStringName(ContractDbProperties.ConnectionStringName)]
public class ContractDbContext : AbpDbContext<ContractDbContext>, IContractDbContext
{
    public DbSet<Models.Contracts.Contract> Contracts { get; }
    
    public ContractDbContext(DbContextOptions<ContractDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureContract();
    }

}
