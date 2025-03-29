using System;
using System.Collections.Generic;

public class Program
{
    private List<Vehicle> vehicles = new List<Vehicle>();
    private List<Client> clients = new List<Client>();
    private List<RentalContract> contracts = new List<RentalContract>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    public void CreateContract(Client client, Vehicle vehicle, int rentalDays)
    {
        RentalContract contract = new RentalContract(client, vehicle, rentalDays);
        contracts.Add(contract);
    }

    public void DisplayAllContracts()
    {
        foreach (RentalContract contract in contracts)
        {
            contract.DisplayContractDetails();
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Program program = new Program();

        // Get client information
        Console.WriteLine("Enter client's name:");
        string clientName = Console.ReadLine();

        Console.WriteLine("Enter client's driver's license number:");
        string driversLicense = Console.ReadLine();

        Console.WriteLine("Enter client's phone number:");
        string phoneNumber = Console.ReadLine();

        Client client = new Client(clientName, driversLicense, phoneNumber);
        program.AddClient(client);

        // Get vehicle information
        Console.WriteLine("Enter vehicle type (Car, Motorcycle, Truck):");
        string vehicleType = Console.ReadLine().ToLower();

        Console.WriteLine("Enter vehicle model:");
        string model = Console.ReadLine();

        Console.WriteLine("Enter vehicle license plate:");
        string licensePlate = Console.ReadLine();

        Console.WriteLine("Enter daily rental rate:");
        double dailyRate = double.Parse(Console.ReadLine());

        Vehicle vehicle;

        if (vehicleType == "car")
        {
            Console.WriteLine("Enter number of doors:");
            int numDoors = int.Parse(Console.ReadLine());
            vehicle = new Car(model, licensePlate, dailyRate, numDoors);
        }
        else if (vehicleType == "motorcycle")
        {
            Console.WriteLine("Enter engine size (in cc):");
            int engineSize = int.Parse(Console.ReadLine());
            vehicle = new Motorcycle(model, licensePlate, dailyRate, engineSize);
        }
        else if (vehicleType == "truck")
        {
            Console.WriteLine("Enter load capacity (in tons):");
            double loadCapacity = double.Parse(Console.ReadLine());
            vehicle = new Truck(model, licensePlate, dailyRate, loadCapacity);
        }
        else
        {
            Console.WriteLine("Invalid vehicle type.");
            return;
        }

        program.AddVehicle(vehicle);

        // Get rental days
        Console.WriteLine("Enter rental days:");
        int rentalDays = int.Parse(Console.ReadLine());

        program.CreateContract(client, vehicle, rentalDays);

        // Display all contracts
        program.DisplayAllContracts();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
