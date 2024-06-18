using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void RunActivity()
    {
        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            timeElapsed += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            timeElapsed += 3;
        }
    }
}