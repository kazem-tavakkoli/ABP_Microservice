using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(FinanceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class FinanceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(FinanceApplicationContractsModule).Assembly,
            FinanceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FinanceHttpApiClientModule>();
        });

    }
}
