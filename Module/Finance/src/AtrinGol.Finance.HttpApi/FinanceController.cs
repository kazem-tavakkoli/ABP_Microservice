using AtrinGol.Finance.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AtrinGol.Finance;

public abstract class FinanceController : AbpControllerBase
{
    protected FinanceController()
    {
        LocalizationResource = typeof(FinanceResource);
    }
}
