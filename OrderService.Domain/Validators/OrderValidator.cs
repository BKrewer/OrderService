using FluentValidation;
using OrderService.Domain.Entities;

namespace OrderService.Domain.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(order => order.CreatedDate).NotNull().NotEmpty();
            RuleFor(order => order.Status).NotEmpty().NotNull();
            RuleFor(order => order.Customer).NotEmpty().NotNull();
        }
    }
}
