using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AtrinGol.Finance.EntityFrameworkCore;

[DependsOn(
    typeof(FinanceDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class FinanceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<FinanceDbContext>(options =>
        {
            context.Services.AddAbpDbContext<FinanceDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
        });
    }
}
