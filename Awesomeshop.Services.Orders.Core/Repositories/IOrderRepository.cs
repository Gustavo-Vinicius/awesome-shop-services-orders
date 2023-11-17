using Awesomeshop.Services.Orders.Core.Entities;

namespace Awesomeshop.Services.Orders.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(Guid id);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
    }
}