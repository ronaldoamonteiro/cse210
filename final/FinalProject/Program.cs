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
        bool running = true;

        while (running)
        {
            Console.WriteLine("=== Vehicle Rental System ===");
            Console.WriteLine("1. Register Driver");
            Console.WriteLine("2. Register Vehicle");
            Console.WriteLine("3. Rent Vehicle");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter client's name: ");
                    string clientName = Console.ReadLine();

                    Console.Write("Enter client's driver's license number: ");
                    string driversLicense = Console.ReadLine();

                    Console.Write("Enter client's phone number: ");
                    string phoneNumber = Console.ReadLine();

                    Client client = new Client(clientName, driversLicense, phoneNumber);
                    program.AddClient(client);
                    Console.WriteLine("Driver registered successfully.\n");
                    break;

                case "2":
                    Console.Write("Enter vehicle type (Car, Motorcycle, Truck): ");
                    string vehicleType = Console.ReadLine().ToLower();

                    Console.Write("Enter vehicle model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter vehicle license plate: ");
                    string licensePlate = Console.ReadLine();

                    Console.Write("Enter daily rental rate: ");
                    double dailyRate = double.Parse(Console.ReadLine());

                    Vehicle vehicle;

                    if (vehicleType == "car")
                    {
                        Console.Write("Enter number of doors: ");
                        int numDoors = int.Parse(Console.ReadLine());
                        vehicle = new Car(model, licensePlate, dailyRate, numDoors);
                    }
                    else if (vehicleType == "motorcycle")
                    {
                        Console.Write("Enter engine size (in cc): ");
                        int engineSize = int.Parse(Console.ReadLine());
                        vehicle = new Motorcycle(model, licensePlate, dailyRate, engineSize);
                    }
                    else if (vehicleType == "truck")
                    {
                        Console.Write("Enter load capacity (in tons): ");
                        double loadCapacity = double.Parse(Console.ReadLine());
                        vehicle = new Truck(model, licensePlate, dailyRate, loadCapacity);
                    }
                    else
                    {
                        Console.WriteLine("Invalid vehicle type.\n");
                        break;
                    }

                    program.AddVehicle(vehicle);
                    Console.WriteLine("Vehicle registered successfully.\n");
                    break;

                case "3":
                    if (program.clients.Count == 0 || program.vehicles.Count == 0)
                    {
                        Console.WriteLine("You must register at least one client and one vehicle first.\n");
                        break;
                    }

                    Console.Write("Choose a client by number: ");
                    for (int i = 0; i < program.clients.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {program.clients[i].GetClientInfo()}");
                    }
                    int clientIndex = int.Parse(Console.ReadLine()) - 1;
                    Client selectedClient = program.clients[clientIndex];

                    Console.Write("Choose a vehicle by number: ");
                    for (int i = 0; i < program.vehicles.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        program.vehicles[i].DisplayDetails();
                    }
                    int vehicleIndex = int.Parse(Console.ReadLine()) - 1;
                    Vehicle selectedVehicle = program.vehicles[vehicleIndex];

                    Console.Write("Enter rental days: ");
                    int rentalDays = int.Parse(Console.ReadLine());

                    program.CreateContract(selectedClient, selectedVehicle, rentalDays);
                    Console.WriteLine("Rental completed successfully.\n");
                    program.DisplayAllContracts();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.\n");
                    break;
            }
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }
}
