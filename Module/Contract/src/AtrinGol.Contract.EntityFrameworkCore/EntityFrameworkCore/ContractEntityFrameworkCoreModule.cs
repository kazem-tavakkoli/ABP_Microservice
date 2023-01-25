using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AtrinGol.Contract.EntityFrameworkCore;

[DependsOn(
    typeof(ContractDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ContractEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ContractDbContext>(options =>
        {
            context.Services.AddAbpDbContext<ContractDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
        });
    }
}
