using System;

namespace OrderService.Domain.Entities
{
    public class Order
    {
        public Order(DateTime createdDate, decimal total, int status)
        {
            CreatedDate = createdDate;
            Total = total;
            Status = status;
        }

        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public decimal Total { get; private set; }
        public int Status { get; private set; }
    }
}
