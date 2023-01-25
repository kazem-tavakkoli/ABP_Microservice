using AtrinGol.Finance.Localization;
using Volo.Abp.Application.Services;

namespace AtrinGol.Finance;

public abstract class FinanceAppService : ApplicationService
{
    protected FinanceAppService()
    {
        LocalizationResource = typeof(FinanceResource);
        ObjectMapperContext = typeof(FinanceApplicationModule);
    }
}
