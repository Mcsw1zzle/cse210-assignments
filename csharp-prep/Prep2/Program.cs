using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int x = int.Parse(userInput);

        string letterGrade = "";

        if (x >= 90)
        {
            letterGrade = "A";
        }
        else if (x >= 80)
        {
            letterGrade = "B";
        }
        else if (x >= 70)
        {
            letterGrade = "C";
        }
        else if (x >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your grade is: {letterGrade}");

        if (x >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass, better luck next time!");
        }

    }
}