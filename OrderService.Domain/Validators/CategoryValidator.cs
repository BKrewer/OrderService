using FluentValidation;
using OrderService.Domain.Entities;

namespace OrderService.Domain.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() {}
    }
}
