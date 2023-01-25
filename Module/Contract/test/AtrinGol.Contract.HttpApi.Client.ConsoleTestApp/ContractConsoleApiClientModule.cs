using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ContractHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ContractConsoleApiClientModule : AbpModule
{

}
