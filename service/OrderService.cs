using Crm.Entities;
namespace Crm.Services;

public sealed class OrderService : OrderServiceBase
{

    private List<Order> orders = new();
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

        orders.Add(newOrder);

        return newOrder;
    }

    public void PrintAllOrders()
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(order);
            Console.WriteLine("------------------------------------");
        }
    }

    public void ChangeOrderDescription(int ID)
    {
        int length = orders.Count;
        for (int i = 0; i < length; i++)
        {
            if (orders[i].ID == ID)
            {
                Console.WriteLine("Add new description: ");
                string? description = Console.ReadLine();
                orders[i].Description = description;
                break;
            }
        }
    }

    public void DeleteOrder(int id)
    {
        orders.RemoveAt(id);
        Console.WriteLine($"Order with id {id} deleted successfully!");
        Console.WriteLine("------------------------------------");
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