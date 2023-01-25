using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FinanceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class FinanceConsoleApiClientModule : AbpModule
{

}
