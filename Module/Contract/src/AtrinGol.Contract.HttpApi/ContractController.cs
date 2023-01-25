using AtrinGol.Contract.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AtrinGol.Contract;

public abstract class ContractController : AbpControllerBase
{
    protected ContractController()
    {
        LocalizationResource = typeof(ContractResource);
    }
}
