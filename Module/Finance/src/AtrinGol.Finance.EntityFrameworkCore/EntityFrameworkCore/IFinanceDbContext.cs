using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AtrinGol.Finance.EntityFrameworkCore;

[ConnectionStringName(FinanceDbProperties.ConnectionStringName)]
public interface IFinanceDbContext : IEfCoreDbContext
{
    DbSet<Models.Finances.Finance> Finances { get; set; }

}
