using FluentValidation;
using OrderService.Domain.Entities;

namespace OrderService.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name).NotNull().NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(product => product.Description).MaximumLength(300);
            RuleFor(product => product.Price).NotNull().NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(product => product.QuantityInStock).NotNull().NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(product => product.CategoryId).NotNull().NotEmpty();
        }
    }
}