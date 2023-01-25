using AtrinGol.Finance;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Http.Client;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(ContractDomainModule),
    typeof(ContractApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpHttpClientModule),
    typeof(FinanceHttpApiClientModule)
)]
public class ContractApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<ContractApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ContractApplicationModule>(validate: true);
        });
    }
}
