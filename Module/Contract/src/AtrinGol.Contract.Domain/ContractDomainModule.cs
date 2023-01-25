using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ContractDomainSharedModule)
)]
public class ContractDomainModule : AbpModule
{

}
