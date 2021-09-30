using OrderService.Domain.Commands;
using OrderService.Domain.Entities;
using OrderService.Domain.Repositories;
using OrderService.Shared.Commands;
using OrderService.Shared.Handlers;
using System.Collections.Generic;

namespace OrderService.Domain.Handlers
{
    public class OrderHandler : IHandler<CreateOrderCommand>
    {
        private readonly ICustomerRepository _customer;
        private readonly IProductRepository _product;
        private readonly IOrderRepository _order;

        public OrderHandler(ICustomerRepository customer, IProductRepository product, IOrderRepository order)
        {
            _customer = customer;
            _product = product;
            _order = order;
        }

        public ICommandResult Handle(CreateOrderCommand command)
        {

            Customer customer = _customer.Get(command.Customer);

            if(!customer.IsValid())
            {
                return new CommandResult(false, "Usuário não encontrado");
            }

            var orderItems = new List<OrderItem>();

            foreach (var item in command.OrderItems)
            {
                var product = _product.Get(item.Product);
                var orderItem = new OrderItem();
                orderItem.AddProduct(product, item.Quantity, item.Price);
                orderItems.Add(orderItem);
            }

            var order = new Order(orderItems, customer);

            if(!order.IsValid())
            {
                return new CommandResult(false, "Não foi possível criar a ordem");
            }

            _order.Save(order);

            return new CommandResult(true, "Ordem criada com sucesso!");
        }
    }
}
