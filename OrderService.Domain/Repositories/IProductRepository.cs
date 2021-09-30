using OrderService.Domain.Entities;

namespace OrderService.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(int id);
    }
}
