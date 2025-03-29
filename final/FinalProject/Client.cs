// Client class to store client details
public class Client
{
    private string Name;
    private string DriversLicense;
    private string PhoneNumber;

    public Client(string name, string driversLicense, string phoneNumber)
    {
        Name = name;
        DriversLicense = driversLicense;
        PhoneNumber = phoneNumber;
    }

    public string GetClientInfo()
    {
        return $"Name: {Name}, License: {DriversLicense}, Phone: {PhoneNumber}";
    }
}
