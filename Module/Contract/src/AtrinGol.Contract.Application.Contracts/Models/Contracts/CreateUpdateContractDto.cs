namespace AtrinGol.Contract.Models.Contracts;

public class CreateUpdateContractDto
{
    public string Title { get; set; }
    public int Order { get; set; }
    public string? Description { get; set; }
}