using Awesomeshop.Services.Orders.Application.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Awesomeshop.Services.Orders.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services){
            services.AddMediatR(typeof(AddOrder));
            return services;
        }
    }
}