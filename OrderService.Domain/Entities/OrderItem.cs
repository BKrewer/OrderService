using OrderService.Domain.Validators;
using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class OrderItem : Entity
    {
        private readonly OrderItemValidator _validator = new();

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

        public bool IsValid()
        {
            return _validator.Validate(this).IsValid;
        }
    }
}
