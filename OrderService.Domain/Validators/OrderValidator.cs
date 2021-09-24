using FluentValidation;
using OrderService.Domain.Entities;

namespace OrderService.Domain.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator() { }
    }
}
