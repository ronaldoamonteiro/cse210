using System;

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    { }

    protected override void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(3);
            Console.Write("Now breathe out... ");
            ShowCountdown(3);
        }
    }
}
