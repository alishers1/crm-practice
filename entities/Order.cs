namespace Crm.Entities;

public sealed class Order 
{
    public double _price; 
    public string _delivery;
    public string _address; 

    public int ID { get; init; }
    public string? Description { get; set; }
    public double Price {
        get => _price; 
        init => _price = value > 0 ? value : throw new ArgumentException("Price can't be lower than one");
    }
    public DateTime Date { get; init; }
    public string? Delivery {
        get => _delivery ?? string.Empty;
        init => _delivery = value is { Length: > 0} ? value: throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string? Address {
        get => _address ?? string.Empty;
        init => _address     = value is { Length: > 0} ? value: throw new ArgumentOutOfRangeException(nameof(value));
    }

    public Order(int id, double price)
    {
       ID = id; 
       Price = price;
    }

    public override string ToString()
    {
        return $"Order ID: {ID}\n" + 
               $"Description: {Description}\n" +
               $"Price: {Price}\n" + 
               $"Date: {Date}\n" + 
               $"Delivery: {Delivery}\n" +
               $"Address: {Address}";
    }
}

public readonly struct OrderInfo
{
    public readonly int ID {get; init;}
    public readonly string Description  {get; init;}
    public readonly double Price {get; init;}
    public readonly DateTime Date  {get; init;}
    public readonly string Delivery  {get; init;}
    public readonly string Address  {get; init;}

    public OrderInfo(
        int id,
        string description,
        double price,
        DateTime date, 
        string delivery,
        string address
    )
    {
        ID = id;
        Description = description;
        Price = price;
        Date = date;
        Delivery = delivery;
        Address = address;

    }
}
