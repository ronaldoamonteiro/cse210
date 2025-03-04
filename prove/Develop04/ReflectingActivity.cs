using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private static List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectingActivity() 
        : base("Reflecting Activity", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { }

    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"\nConsider the following prompt:\n---- {prompt} ----\n");
        Console.Write("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"\n> {question} ");
            ShowSpinner(_duration/3);
        }
    }
}
