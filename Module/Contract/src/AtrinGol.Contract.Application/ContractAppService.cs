using AtrinGol.Contract.Localization;
using Volo.Abp.Application.Services;

namespace AtrinGol.Contract;

public abstract class ContractAppService : ApplicationService
{
    protected ContractAppService()
    {
        LocalizationResource = typeof(ContractResource);
        ObjectMapperContext = typeof(ContractApplicationModule);
    }
}
