using OrderService.Shared.Commands;

namespace OrderService.Domain.Commands
{
    class CreateProductCommand : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
    }
}
