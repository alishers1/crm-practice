using Crm.Entities; 
using Crm.Validate;
namespace Crm.Services;

public sealed class ClientService : BaseService, IClientService
{
    private List<Client> clients = new();

    public Client CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new Client()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender
        };

        if (!Validation.ValidateClient(newClient))
        {
            return null;
        }

        clients.Add(newClient);


        return newClient;
    }

    public Client ChangeFirstAndLastName(ClientInfo clientInfo)
    {
        Client newClient = new Client()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender
        };

        newClient.FirstName = "Alisher"; 
        newClient.LastName = "Siddiqov";

        return newClient;
    }

    public void DeleteClient(short index)
    {
        clients.RemoveAt(index);
        Console.WriteLine($"Client with index {index} deleted successfully!");
        Console.WriteLine("------------------------------------");
    }

    public void PrintAllClients()
    {
        foreach (Client client in clients)
        {
            Console.WriteLine(client);
            Console.WriteLine("------------------------------------");
        }
    }
}

public interface IClientService
{
    Client CreateClient(ClientInfo clientInfo);
}

public abstract class BaseService 
{
    protected bool ValidateClient(Client client)
    {
        return true;
    }
}
