// Truck class inherits Vehicle
public class Truck : Vehicle
{
    private double LoadCapacity;

    public Truck(string model, string licensePlate, double dailyRate, double loadCapacity)
        : base(model, licensePlate, dailyRate)
    {
        LoadCapacity = loadCapacity;
    }

    // Override rental calculation method
    public override double CalculateRental(int days)
    {
        return DailyRate * days * 1.5; // 50% extra for trucks
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Truck: {Model}, Plate: {LicensePlate}, Load: {LoadCapacity} Ton, Rate: ${DailyRate}/day");
    }
}
