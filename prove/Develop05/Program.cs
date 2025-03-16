using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();
                    Console.Write("Goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Short description: ");
                    string description = Console.ReadLine();
                    Console.Write("Amount of points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                        manager.AddGoal(new SimpleGoal(name, description, points));
                    else if (goalType == "2")
                        manager.AddGoal(new EternalGoal(name, description, points));
                    else if (goalType == "3")
                    {
                        Console.Write("How many times to accomplish goal: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points when complete: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    break;

                case "2":
                    manager.ListGoals();
                    break;

                case "3":
                    Console.Write("Filename to save goals: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Filename to load goals: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "5":
                    manager.ListGoals();
                    Console.Write("Which goal did you accomplish? ");
                    manager.RecordEvent(int.Parse(Console.ReadLine()) - 1);
                    break;

                case "6":
                    running = false;
                    break;
            }
        }
    }
}
