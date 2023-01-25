using Volo.Abp.Application.Dtos;

namespace AtrinGol.Contract.Models.Contracts;

public class ContractDto:AuditedEntityDto<long>
{
    public string Title { get; set; }
    public int Order { get; set; }
    public string? Description { get; set; }
}