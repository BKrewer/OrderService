using OrderService.Domain.Entities;

namespace OrderService.Domain.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
