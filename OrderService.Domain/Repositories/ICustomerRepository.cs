using OrderService.Domain.Entities;

namespace OrderService.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(int id);
    }
}
