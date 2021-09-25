using FluentValidation;
using OrderService.Domain.ValueObjects;

namespace OrderService.Domain.Validators
{
    public class NameValidator : AbstractValidator<Name>
    {
        public NameValidator()
        {
            RuleFor(name => name.FirstName).NotNull().NotEmpty();
            RuleFor(name => name.LastName).NotNull().NotEmpty();
        }
    }
}
