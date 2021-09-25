using FluentValidation;
using OrderService.Domain.ValueObjects;

namespace OrderService.Domain.Validators
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(email => email.Address).NotNull().NotEmpty().EmailAddress();
        }
    }
}
