// Car class inherits Vehicle
public class Car : Vehicle
{
    private int NumDoors;

    public Car(string model, string licensePlate, double dailyRate, int numDoors)
        : base(model, licensePlate, dailyRate)
    {
        NumDoors = numDoors;
    }

    // Override rental calculation method
    public override double CalculateRental(int days)
    {
        return DailyRate * days * 1.1; // 10% extra for cars
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Car: {Model}, Plate: {LicensePlate}, Doors: {NumDoors}, Rate: ${DailyRate}/day");
    }
}
