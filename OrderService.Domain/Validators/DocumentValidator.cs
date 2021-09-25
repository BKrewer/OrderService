using FluentValidation;
using OrderService.Domain.ValueObjects;

namespace OrderService.Domain.Validators
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(doc => doc.Number).NotEmpty().NotNull().MinimumLength(11);
            RuleFor(doc => doc.Type).NotNull().NotEmpty();
        }
    }
}
