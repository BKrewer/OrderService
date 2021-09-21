using OrderService.Domain.Enums;
using OrderService.Shared.Entities;
using System;

namespace OrderService.Domain.Entities
{
    public class Order : Entity
    {
        public Order(DateTime createdDate, decimal total, EOrderStatus status)
        {
            CreatedDate = createdDate;
            Total = total;
            Status = status;
        }
        public DateTime CreatedDate { get; private set; }
        public decimal Total { get; private set; }
        public EOrderStatus Status { get; private set; }

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }
    }
}
