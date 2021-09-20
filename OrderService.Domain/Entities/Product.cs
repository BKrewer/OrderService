namespace OrderService.Domain.Entities
{
    public class Product
    {
        public Product(string name, string description, decimal price, int quantityInStock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            Image = image;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityInStock { get; private set; }

        public string Image { get; private set; }
    }
}
