using Awesomeshop.Services.Orders.Core.Entities;
using Awesomeshop.Services.Orders.Core.Repositories;

namespace Awesomeshop.Services.Orders.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        //private readonly IMongoCollection<Order>

        public OrderRepository()
        {
            
        }
        public Task AddAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }

    }
}