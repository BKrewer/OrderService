using OrderService.Domain.ValueObjects;
using OrderService.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

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
    }
}
