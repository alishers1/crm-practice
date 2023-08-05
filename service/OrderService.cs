using Crm.Entities;
namespace Crm.Services;

public sealed class OrderService : OrderServiceBase
{
    public override Order CreateOrder(OrderInfo orderInfo)
    {
        Order newOrder = new Order(12, 57)
        {
            ID = orderInfo.ID,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Delivery = orderInfo.Delivery,
            Address = orderInfo.Address,
        };

        return newOrder;
    }
}

public interface IOrderService
{
    Order CreateOrder(OrderInfo orderInfo);
}

public abstract class OrderServiceBase : IOrderService
{
    public abstract Order CreateOrder(OrderInfo orderInfo);
}