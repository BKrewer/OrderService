using OrderService.Domain.ValueObjects;
using OrderService.Shared.Entities;

namespace OrderService.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(Name name, Email email, Document document)
        {
            Name = name;
            Email = email;
            Document = document;
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Document Document { get; private set; }

        public bool IsValid()
        {
            return Name.IsValid() && Email.IsValid() && Document.IsValid();
        }
    }
}
