using Volo.Abp.Modularity;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(FinanceApplicationModule),
    typeof(FinanceDomainTestModule)
    )]
public class FinanceApplicationTestModule : AbpModule
{

}
