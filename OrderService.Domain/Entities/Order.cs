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

        public Order(IList<OrderItem> orderItems, Customer customer)
        {
            CreatedDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Customer = customer;
            _orderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(item => AddItem(item));
        }

        public DateTime CreatedDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in _orderItems)
                {
                    total += (item.Price * item.Quantity);
                }

                return total;
            }
        }

        public Customer Customer { get; private set; }

        public IReadOnlyCollection<OrderItem> OrderItems { get { return _orderItems.ToArray(); } }

        public void AddItem(OrderItem orderItem)
        {
            _orderItems.Add(orderItem);
        }

        public void MarkAsPaid()
        {
            Status = EOrderStatus.Paid;
        }

        public void MarkAsDelivered()
        {
            Status = EOrderStatus.Delivered;
        }

        public void MarkAsCanceled()
        {
            Status = EOrderStatus.Canceled;
        }
    }
}
