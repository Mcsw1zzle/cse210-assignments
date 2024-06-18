using System;

public class ExerciseActivity : Activity
{
    public ExerciseActivity() : base("Exercise Activity", "This activity is designed to help get your blood flowing and your mind energized by performing squats for a specific time frame.")
    {        
    }

    protected override void RunActivity()
    {
        int timeElapsed = 0;
        while(timeElapsed < duration)
        {
            Console.WriteLine("Squat down...");
            ShowCountdown(3);
            timeElapsed += 3;

            Console.WriteLine("And up!");
            ShowCountdown(2);
            timeElapsed += 2;
        }
    }
}

