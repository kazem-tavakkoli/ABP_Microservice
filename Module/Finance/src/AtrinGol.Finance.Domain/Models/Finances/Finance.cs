using Volo.Abp.Domain.Entities.Auditing;

namespace AtrinGol.Finance.Models.Finances
{
    public class Finance:AuditedAggregateRoot<long>
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public string? Description { get; set; }
    }
}