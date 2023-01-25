using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AtrinGol.Finance.EntityFrameworkCore;

[ConnectionStringName(FinanceDbProperties.ConnectionStringName)]
public class FinanceDbContext : AbpDbContext<FinanceDbContext>, IFinanceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public FinanceDbContext(DbContextOptions<FinanceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureFinance();
    }

    public DbSet<Models.Finances.Finance> Finances { get; set; }
}
