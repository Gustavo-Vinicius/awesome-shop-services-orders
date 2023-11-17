using Awesomeshop.Services.Orders.Core.Entities;

namespace Awesomeshop.Services.Orders.Application.Dtos.ViewModels
{
    public class OrderViewModel
    {
        public OrderViewModel(Guid id, decimal totalPrice, DateTime createAt, string status)
        {
            Id = id;
            TotalPrice = totalPrice;
            CreateAt = createAt;
            Status = status;
        }


        public Guid Id { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime CreateAt { get; private set; }
        public string Status { get; private set; }

        public static OrderViewModel FromEntity(Order order){
            return new OrderViewModel(order.Id, order.TotalPrice, order.CreateAt, order.Status.ToString());
        }
    }
}