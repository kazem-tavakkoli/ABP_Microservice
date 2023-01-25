using AtrinGol.Finance.Model.Finances;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AtrinGol.Finance.Models.Finances;

public class FinanceAppService:CrudAppService<Models.Finances.Finance,
    FinanceDto,
    long,
    PagedResultRequestDto,
    CreateUpdateFinanceDto>,
    IFinanceAppService
{
    public FinanceAppService(IRepository<Models.Finances.Finance, long> repository) : base(repository)
    {
    }
}