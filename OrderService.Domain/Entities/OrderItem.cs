using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem() { }

        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public int OrderId { get; private set; }
        public Order Order { get; private set; }

        public int ProductId { get; private set; }
        public Product Product { get; private set; }

        public void AddProduct(Product product, int quantity, decimal price)
        {
            ProductId = product.Id;
            Product = product;
            Quantity = quantity;
            Price = price;

            Product.UpdateQuantityOnHand(quantity);
        }

    }
}
