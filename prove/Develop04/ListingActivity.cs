using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        ShowCountdown(5);

        List<string> items = new List<string>();
        int timeElapsed = 0;
        while (timeElapsed < duration)
        {
            Console.Write("< ");
            items.Add(Console.ReadLine());
            timeElapsed += 5;
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}