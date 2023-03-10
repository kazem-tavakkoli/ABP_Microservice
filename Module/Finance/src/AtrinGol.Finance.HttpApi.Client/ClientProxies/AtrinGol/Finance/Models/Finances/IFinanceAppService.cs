// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using AtrinGol.Finance.Model.Finances;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

// ReSharper disable once CheckNamespace
namespace AtrinGol.Finance.Models.Finances;

public interface IFinanceAppService : IApplicationService
{
    Task<FinanceDto> GetAsync(long id);

    Task<PagedResultDto<FinanceDto>> GetListAsync(PagedResultRequestDto input);

    Task<FinanceDto> CreateAsync(CreateUpdateFinanceDto input);

    Task<FinanceDto> UpdateAsync(long id, CreateUpdateFinanceDto input);

    Task DeleteAsync(long id);
}
