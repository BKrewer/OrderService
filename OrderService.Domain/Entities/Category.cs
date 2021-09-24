using OrderService.Domain.Validators;
using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class Category : Entity
    {
        private readonly CategoryValidator _validator = new();

        public Category(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

        public bool IsValid()
        {
            return _validator.Validate(this).IsValid;
        }
    }
}
