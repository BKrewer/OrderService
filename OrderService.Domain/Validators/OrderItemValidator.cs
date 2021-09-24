using FluentValidation;
using OrderService.Domain.Entities;

namespace OrderService.Domain.Validators
{
    public class OrderItemValidator : AbstractValidator<OrderItem>
    {
        public OrderItemValidator()
        {
            RuleFor(item => item.Quantity).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(item => item.Price).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(item => item.OrderId).NotNull().NotEmpty();
            RuleFor(item => item.ProductId).NotNull().NotEmpty();
        }
    }
}
