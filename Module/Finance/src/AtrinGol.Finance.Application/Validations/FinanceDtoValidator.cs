using AtrinGol.Finance.Model.Finances;
using FluentValidation;

namespace AtrinGol.Finance.Validations;

public class FinanceDtoValidator:AbstractValidator<CreateUpdateFinanceDto>
{
    public FinanceDtoValidator()
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