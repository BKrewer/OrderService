using OrderService.Domain.Entities;
using Xunit;

namespace OrderService.Tests.Entities
{
    public class OrderItemTests
    {
        [Fact]
        public void ShouldReturnErrorWhenAddProductWithSmallerQtyInStock()
        {
            Product product = new("Prod Teste", "Produto de teste", 1000, 1, "no-image", 1);
            OrderItem orderItem = new();
            orderItem.AddProduct(product, 2, 2000);

            Assert.False(orderItem.IsValid());
        }

        [Fact]
        public void ShouldReturnSuccessWhenAddProductWithLargerQtyInStock()
        {
            Product product = new("Prod Teste", "Produto de teste", 1000, 10, "no-image", 1);
            OrderItem orderItem = new();
            orderItem.AddProduct(product, 2, 2000);

            Assert.True(orderItem.IsValid());
        }
    }
}
