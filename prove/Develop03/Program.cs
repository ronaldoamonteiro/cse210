using System;

class Program
{
    static void Main()
    {
        // Creating the reference and the scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        // Main loop of the program
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
                break;

            scripture.HideWords(); // Hides words progressively
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Program ended.");
    }
}
