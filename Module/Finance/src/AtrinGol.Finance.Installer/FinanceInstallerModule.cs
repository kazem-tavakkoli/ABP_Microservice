using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AtrinGol.Finance;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class FinanceInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FinanceInstallerModule>();
        });
    }
}
