using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Jornal jornal = new Jornal();
        PromptManager prompt = new PromptManager();
        int option = 0;

        Console.WriteLine("Welcome to the Journal Program");

        do{
            menu.Display();
            option = int.Parse(Console.ReadLine());
            if (option == 1){ //Write option
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                jornal.AddEntry("28-Jan-2025", randomPrompt, response);
            }
            else if (option == 2){ //Display Option
                Console.WriteLine("Display option");
            }
            else if (option == 3){ //Load option
                Console.WriteLine("Load option");
            }
            else if (option == 4){ //Save option
                Console.WriteLine("Save option");
            }
            else{ //Quite option
                Console.WriteLine("Quite option");
            }
        }while(option != 5);
    }
}