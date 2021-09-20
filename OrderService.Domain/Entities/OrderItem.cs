namespace OrderService.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(int quantity, decimal price)
        {
            Quantity = quantity;
            Price = price;
        }

        public int Id { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
