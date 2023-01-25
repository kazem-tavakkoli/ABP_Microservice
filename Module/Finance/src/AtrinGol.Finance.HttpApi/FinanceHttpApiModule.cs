using Localization.Resources.AbpUi;
using AtrinGol.Finance.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(FinanceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class FinanceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(FinanceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<FinanceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
