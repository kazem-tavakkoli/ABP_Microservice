using Volo.Abp.Application.Dtos;

namespace AtrinGol.Finance.Model.Finances;

public class FinanceDto:AuditedEntityDto<long>
{
    public string Title { get; set; }
    public int Order { get; set; }
    public string? Description { get; set; }
}