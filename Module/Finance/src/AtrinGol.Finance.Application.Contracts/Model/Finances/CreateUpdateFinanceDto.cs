using JetBrains.Annotations;

namespace AtrinGol.Finance.Model.Finances;

public class CreateUpdateFinanceDto
{
    public string Title { get; set; }
    public int Order { get; set; }
     public string? Description { get; set; }
}