using OrderService.Domain.Validators;
using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class Product : Entity
    {
        private readonly ProductValidator _validator = new();

        public Product(string name, string description, decimal price, int quantityInStock, string image, int categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            Image = image;
            CategoryId = categoryId;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityInStock { get; private set; }
        public string Image { get; private set; }

        public int CategoryId { get; private set; }
        public Category Category { get; private set; }

        public void UpdateQuantityOnHand(int qtyToSubtract)
        {
            QuantityInStock -= qtyToSubtract;
        }

        public bool IsValid()
        {
            return _validator.Validate(this).IsValid;
        }
    }
}
