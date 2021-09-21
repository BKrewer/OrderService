using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(int quantity, decimal price)
        {
            Quantity = quantity;
            Price = price;
        }

        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

    }
}
