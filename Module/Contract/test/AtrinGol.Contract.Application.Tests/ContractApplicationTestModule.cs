using Volo.Abp.Modularity;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(ContractApplicationModule),
    typeof(ContractDomainTestModule)
    )]
public class ContractApplicationTestModule : AbpModule
{

}
