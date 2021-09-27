using OrderService.Domain.Entities;
using OrderService.Domain.Enums;
using OrderService.Domain.ValueObjects;
using System.Collections.Generic;
using Xunit;

namespace OrderService.Tests.Entities
{
    public class OrderTests
    {
        private readonly Customer _customer;
        public OrderTests() 
        {
            Name name = new("Bruno", "Dev");
            Document document = new("35111507795", EDocumentType.CPF);
            Email email = new("bruno@br.com");

            _customer = new(name, email, document);
        }

        [Fact]
        public void ShouldReturnErrorWhenAddOrderItemWithoutProduct()
        {
            List<OrderItem> orderItems = new();
            OrderItem orderItem = new();
            orderItems.Add(orderItem);

            Order order = new(orderItems, _customer);

            Assert.False(order.IsValid());
        }

        [Fact]
        public void ShouldReturnSuccessWhenAddOrderItemWithProduct()
        {
            Product product = new("Prod Teste", "Produto de teste", 1000, 10, "no-image", 1);

            List<OrderItem> orderItems = new();
            OrderItem orderItem = new();
            orderItem.AddProduct(product, 1, 1000);

            orderItems.Add(orderItem);

            Order order = new(orderItems, _customer);

            Assert.True(order.IsValid());
        }
    }
}
