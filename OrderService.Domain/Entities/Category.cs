namespace OrderService.Domain.Entities
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
