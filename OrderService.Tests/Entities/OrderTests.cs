using OrderService.Domain.Entities;
using OrderService.Domain.Enums;
using OrderService.Domain.ValueObjects;
using System.Collections.Generic;
using Xunit;

namespace OrderService.Tests.Entities
{
    public class OrderTests
    {
        private readonly Order _order;

        public OrderTests() 
        {
            Name name = new("Bruno", "Dev");
            Document document = new("35111507795", EDocumentType.CPF);
            Email email = new("bruno@br.com");
            
            Customer customer = new(name, email, document);
            List<OrderItem> orderItems = new();
            _order = new(orderItems, customer);
        }
    }
}
