using FluentValidation;
using OrderService.Domain.ValueObjects;

namespace OrderService.Domain.Validators
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator() {}
    }
}
