using Awesomeshop.Services.Orders.Application.Dtos.ViewModels;
using MediatR;

namespace Awesomeshop.Services.Orders.Application.Queries
{
    public class GetOrderById : IRequest<OrderViewModel>
    {
        public GetOrderById(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}