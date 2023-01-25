using AtrinGol.Contract.Models.Contracts;
using FluentValidation;

namespace AtrinGol.Contract.Validations;

public class CrateUpdateContractDtoValidator:AbstractValidator<CreateUpdateContractDto>
{
    public CrateUpdateContractDtoValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MinimumLength(1)
            .MaximumLength(70);
        RuleFor(x => x.Order)
            .NotEmpty()
            .GreaterThanOrEqualTo(0);
        RuleFor(x => x.Description)
            .MinimumLength(1)
            .MaximumLength(500)
            .When(x => x.Description is not null);
    }
}