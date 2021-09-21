using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
