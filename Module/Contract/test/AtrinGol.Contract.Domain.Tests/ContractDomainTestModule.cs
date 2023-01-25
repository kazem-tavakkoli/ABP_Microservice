using AtrinGol.Contract.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AtrinGol.Contract;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ContractEntityFrameworkCoreTestModule)
    )]
public class ContractDomainTestModule : AbpModule
{

}
