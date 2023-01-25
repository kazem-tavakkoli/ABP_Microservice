using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FinanceDomainSharedModule)
)]
public class FinanceDomainModule : AbpModule
{

}
