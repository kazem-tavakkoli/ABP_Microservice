using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AtrinGol.Finance.Model.Finances;

public interface IFinanceAppService:ICrudAppService<FinanceDto,long,PagedResultRequestDto,CreateUpdateFinanceDto>,IApplicationService
{
    
}