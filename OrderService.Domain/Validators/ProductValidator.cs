using FluentValidation;
using OrderService.Domain.Entities;

namespace OrderService.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() { }
    }
}
