// Abstract Vehicle class
public abstract class Vehicle
{
    protected string Model;
    protected string LicensePlate;
    protected double DailyRate;

    public Vehicle(string model, string licensePlate, double dailyRate)
    {
        Model = model;
        LicensePlate = licensePlate;
        DailyRate = dailyRate;
    }

    public string GetModel() => Model;
    public string GetLicensePlate() => LicensePlate;
    public double GetDailyRate() => DailyRate;

    public abstract double CalculateRental(int days);
    public abstract void DisplayDetails();
}
