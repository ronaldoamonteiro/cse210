// RentalContract class associates client and vehicle
public class RentalContract
{
    private Client Client;
    private Vehicle Vehicle;
    private int RentalDays;
    private double TotalPrice;

    public RentalContract(Client client, Vehicle vehicle, int rentalDays)
    {
        Client = client;
        Vehicle = vehicle;
        RentalDays = rentalDays;
        TotalPrice = CalculateTotalPrice();
    }

    public double CalculateTotalPrice()
    {
        return Vehicle.CalculateRental(RentalDays);
    }

    public void DisplayContractDetails()
    {
        Console.WriteLine("--- Rental Contract Details ---");
        Console.WriteLine(Client.GetClientInfo());
        Vehicle.DisplayDetails();
        Console.WriteLine($"Days: {RentalDays}, Total Price: ${TotalPrice:F2}");
    }
}
