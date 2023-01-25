using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AtrinGol.Contract.Models.Contracts;

public interface IContractAppService:ICrudAppService<ContractDto,long,PagedResultRequestDto,CreateUpdateContractDto>,IApplicationService
{
    
}