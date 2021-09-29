using OrderService.Shared.Commands;

namespace OrderService.Domain.Commands
{
    public class CreateOrderItemCommand : ICommand
    {
        public int Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
