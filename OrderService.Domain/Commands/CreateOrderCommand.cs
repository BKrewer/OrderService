using OrderService.Shared.Commands;
using System.Collections.Generic;

namespace OrderService.Domain.Commands
{
    public class CreateOrderCommand : ICommand
    {
        public int Customer { get; set; }
        public IList<CreateOrderItemCommand> OrderItems { get; set; }
    }
}
