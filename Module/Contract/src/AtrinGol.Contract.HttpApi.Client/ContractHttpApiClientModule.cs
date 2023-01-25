using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(ContractApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ContractHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ContractApplicationContractsModule).Assembly,
            ContractRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ContractHttpApiClientModule>();
        });

    }
}
