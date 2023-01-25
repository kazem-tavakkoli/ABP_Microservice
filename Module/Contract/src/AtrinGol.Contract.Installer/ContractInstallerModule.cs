using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AtrinGol.Contract;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class ContractInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ContractInstallerModule>();
        });
    }
}
