using Crm.Entities; 
using Crm.Services;

ClientService ClientService = new();
OrderService OrderService = new();

while (true)
{
    Console.WriteLine("Enter the command:\nCreate Client - 1\nChange First and Last name of Client - 2\n"+
    "Delete Client - 3\nPrint all clients - 4\nCreate Order - 5\nChange order description - 6\n"+
    "Print all orders - 7\nDelete order - 8\nExit - 9\n"+
    "------------------------------");

    int cmd = short.Parse(Console.ReadLine());

    if (cmd.Equals(1))
    {
        Console.Write("Enter client name: ");
        string? firstName = Console.ReadLine();

        Console.Write("Enter client lastname: ");
        string? lastName = Console.ReadLine();

        Console.Write("Enter client middlename: ");
        string? middleName = Console.ReadLine();

        Console.Write("Enter client age: ");
        short age = short.Parse(Console.ReadLine());

        Console.Write("Enter client passport number: ");
        string? passportNumber = Console.ReadLine();

        Console.Write("Enter client gender: ");
        string? gender = Console.ReadLine();

        Console.WriteLine("------------------------------------");

        ClientInfo clientInfo = new ClientInfo(
            firstName,
            lastName,
            middleName,
            age,
            passportNumber,
            gender
        );

        ClientService.CreateClient(clientInfo);
    }

    if (cmd.Equals(2))
    {
        Console.Write("Enter client name: ");
        string? firstName = Console.ReadLine();

        Console.Write("Enter client lastname: ");
        string? lastName = Console.ReadLine();

        Console.Write("Enter client middlename: ");
        string? middleName = Console.ReadLine();

        Console.Write("Enter client age: ");
        short age = short.Parse(Console.ReadLine());

        Console.Write("Enter client passport number: ");
        string? passportNumber = Console.ReadLine();

        Console.Write("Enter client gender: ");
        string? gender = Console.ReadLine();

        ClientInfo clientInfo = new ClientInfo(
            firstName,
            lastName,
            middleName,
            age,
            passportNumber,
            gender
        );

        Client newClient = ClientService.ChangeFirstAndLastName(clientInfo);

        Console.WriteLine("\n" + newClient);
    }

    if (cmd.Equals(3))
    {
        Console.Write("Enter index of client to delete: ");
        short index = short.Parse(Console.ReadLine());
        ClientService.DeleteClient(index);
    }

    if (cmd.Equals(4))
    {
        ClientService.PrintAllClients();
    }

    if (cmd.Equals(5))
    {
        Console.Write("Enter order ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter order description: ");
        string? description = Console.ReadLine();

        Console.Write("Enter order price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter order date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter order delivery status: ");
        string? delivery = Console.ReadLine();

        Console.Write("Enter order address: ");
        string? address = Console.ReadLine();

        Console.WriteLine("-----------------------");

        OrderInfo orderInfo = new OrderInfo(
            id,
            description,
            price,
            date,
            delivery,
            address
        );

        OrderService.CreateOrder(orderInfo);
    }


    if (cmd.Equals(6))
    {
        Console.Write("Order ID: ");
        int id = int.Parse(Console.ReadLine());
        OrderService.ChangeOrderDescription(id);
    }

    if (cmd.Equals(7))
    {
        OrderService.PrintAllOrders();
    }

    if (cmd.Equals(8))
    {
        Console.Write("Order index: ");
        int index = int.Parse(Console.ReadLine());
        OrderService.DeleteOrder(index);
    }

    if (cmd.Equals(9))
    {
        Console.WriteLine("The program ended its work!");
        break;
    }
}





