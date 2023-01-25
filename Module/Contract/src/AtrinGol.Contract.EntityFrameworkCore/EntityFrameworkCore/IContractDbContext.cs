using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AtrinGol.Contract.EntityFrameworkCore;

[ConnectionStringName(ContractDbProperties.ConnectionStringName)]
public interface IContractDbContext : IEfCoreDbContext
{
      DbSet<Models.Contracts.Contract> Contracts { get; }
}
