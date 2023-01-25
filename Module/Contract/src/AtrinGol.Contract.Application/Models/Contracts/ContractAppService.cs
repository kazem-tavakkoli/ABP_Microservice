using System.Threading.Tasks;
using AtrinGol.Finance.Model.Finances;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AtrinGol.Contract.Models.Contracts;

public class ContractAppService:CrudAppService<Contract,
    ContractDto,
    long,
    PagedResultRequestDto,
    CreateUpdateContractDto>,
    IContractAppService
{
    private readonly IFinanceAppService _financeService;
    public ContractAppService(IRepository<Contract, long> repository,IFinanceAppService financeService) : base(repository)
    {
        _financeService = financeService;
    }

    public override async Task<PagedResultDto<ContractDto>> GetListAsync(PagedResultRequestDto input)
    {
        var finance = await _financeService.GetListAsync(input);
        return  await base.GetListAsync(input);
    }

    public override async Task<ContractDto> CreateAsync(CreateUpdateContractDto input)
    {
        var m = await _financeService.CreateAsync(new CreateUpdateFinanceDto
        {
            Title = input.Title,
            Order = input.Order,
            Description = input.Description
        });
        return await base.CreateAsync(input);
    }
}