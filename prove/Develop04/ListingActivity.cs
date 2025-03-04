using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private static List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many as you can in a certain area.")
    { }

    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n---- {prompt} ----\n");
        Console.Write("You may begin in: ");
        ShowCountdown(3);

        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!\n");
    }
}
