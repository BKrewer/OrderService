using OrderService.Domain.Enums;
using OrderService.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.Domain.Entities
{
    public class Order : Entity
    {

        private IList<OrderItem> _orderItems;

        public Order(DateTime createdDate, decimal total, EOrderStatus status)
        {
            CreatedDate = createdDate;
            Total = total;
            Status = status;
            _orderItems = new List<OrderItem>();
        }

        public DateTime CreatedDate { get; private set; }
        public decimal Total { get; private set; }
        public EOrderStatus Status { get; private set; }

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public IReadOnlyCollection<OrderItem> OrderItems { get { return _orderItems.ToArray(); } }
    }
}
