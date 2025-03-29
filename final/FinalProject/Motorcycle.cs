// Motorcycle class inherits Vehicle
public class Motorcycle : Vehicle
{
    private int EngineSize;

    public Motorcycle(string model, string licensePlate, double dailyRate, int engineSize)
        : base(model, licensePlate, dailyRate)
    {
        EngineSize = engineSize;
    }

    // Override rental calculation method
    public override double CalculateRental(int days)
    {
        return DailyRate * days * 0.9; // 10% discount for motorcycles
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Motorcycle: {Model}, Plate: {LicensePlate}, Engine: {EngineSize}cc, Rate: ${DailyRate}/day");
    }
}
