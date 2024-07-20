using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running running = new Running("19 Jul 2024", 45, 5, "Running");
        Cycling cycling = new Cycling("24 Oct 2024", 30, 11, "Cycling");
        Swimming swimming = new Swimming("12 Nov 2024", 20, 35, "Swimming");

        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}