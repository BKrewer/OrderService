using OrderService.Domain.ValueObjects;
using OrderService.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.Domain.Entities
{
    public class Customer : Entity
    {

        private IList<Order> _orders;

        public Customer(Name name, Email email, Document document)
        {
            Name = name;
            Email = email;
            Document = document;
            _orders = new List<Order>();
        }

        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Document Document { get; private set; }
        public IReadOnlyCollection<Order> Orders { get { return _orders.ToArray(); } }
    }
}
