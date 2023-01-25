using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(FinanceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class FinanceApplicationContractsModule : AbpModule
{

}
