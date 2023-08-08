namespace Crm.Entities;


public sealed class Client 
{
    private string _firstName;
    private string _lastName;
    private short? _age;
    private string _gender;


    public string? FirstName { 
        get => _firstName ?? string.Empty; 
        set => _firstName = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public string? LastName {
        get => _lastName ?? string.Empty; 
        set => _lastName = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string? MiddleName { get; init; }
    public short? Age {
        get => _age; 
        init => _age = value > 18 ? value : throw new ArgumentException("Age is lower than 18!");
    }
    public string? PassportNumber { get; init; }
    public string? Gender {
        get => _gender ?? string.Empty; 
        init => _gender = value == "Male" || value == "Female" ? value : throw new ArgumentException("Gender must be either 'Male' or 'Female'.");
    }

    // public Client(string firstName, string lastName, short age)
    // {
    //     FirstName = firstName;
    //     LastName = lastName;
    //     Age = age;
    // }

    public override string ToString()
    {
        return $"Client Name: {FirstName} {LastName}\n" + 
               $"Middle Name: {MiddleName}\n" +
               $"Age: {Age}\n" + 
               $"Passport Number: {PassportNumber}\n" + 
               $"Gender: {Gender}";
    }
}

public readonly struct ClientInfo
{
    public readonly string FirstName {get; init;}
    public readonly string LastName  {get; init;}
    public readonly string MiddleName {get; init;}
    public readonly short Age  {get; init;}
    public readonly string PassportNumber  {get; init;}
    public readonly string Gender  {get; init;}


    public ClientInfo(
        string firstName,
        string lastName,
        string middleName,
        short age, 
        string passportNumber,
        string gender
    )
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Age = age;
        PassportNumber = passportNumber;
        Gender = gender;
    }
}