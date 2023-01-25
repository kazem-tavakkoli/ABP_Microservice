using Volo.Abp.Domain.Entities.Auditing;

namespace AtrinGol.Contract.Models.Contracts {
    public class Contract:AuditedAggregateRoot<long>
    {
        public string Title { get; set; }
        public int Order { get; set; }
        public string? Description { get; set; }
    }
}