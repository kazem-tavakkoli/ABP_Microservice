using Localization.Resources.AbpUi;
using AtrinGol.Contract.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(ContractApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ContractHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ContractHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ContractResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
