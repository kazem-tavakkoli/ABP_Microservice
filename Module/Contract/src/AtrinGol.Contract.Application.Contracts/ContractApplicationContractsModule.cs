using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(ContractDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ContractApplicationContractsModule : AbpModule
{

}
