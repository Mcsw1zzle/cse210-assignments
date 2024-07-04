using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            totalScore += goal.RecordEvent();
            Console.WriteLine($"{goalName} recorded! Current score: {totalScore}");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
            Console.WriteLine(" ");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        Console.WriteLine(" ");
        foreach (var goal in goals)
        {
            string status = goal.IsComplete ? "[X]" : "[ ]";
            string details = goal is ChecklistGoal checklistGoal ?
                $"Completed {checklistGoal.CurrentCompletions}/{checklistGoal.RequiredCompletions} times" : "";
            Console.WriteLine($"{status} {goal.Name} {details}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                string goalType = goal.GetType().Name;
                string goalDetails = goalType switch
                {
                    nameof(SimpleGoal) => $"{goalType}:{goal.Name},{goal.Points}",
                    nameof(EternalGoal) => $"{goalType}:{goal.Name},{goal.Points}",
                    nameof(ChecklistGoal) => $"{goalType}:{goal.Name},{goal.Points},{((ChecklistGoal)goal).RequiredCompletions},{((ChecklistGoal)goal).BonusPoints}",
                    _ => throw new ArgumentException($"Unknown goal type: {goalType}")
                };
                outputFile.WriteLine(goalDetails);
            }
            outputFile.WriteLine($"TotalScore:{totalScore}");
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        goals.Clear();
        if (File.Exists(filename))
        {
            using (StreamReader inputFile = new StreamReader(filename))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    if (line.StartsWith("SimpleGoal:") || line.StartsWith("EternalGoal:") || line.StartsWith("ChecklistGoal:"))
                    {
                        string[] parts = line.Split(':');
                        string[] details = parts[1].Split(',');
                        string goalType = parts[0];
                        string name = details[0];
                        int points = int.Parse(details[1]);

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goals.Add(new SimpleGoal(name, points));
                                break;
                            case "EternalGoal":
                                goals.Add(new EternalGoal(name, points));
                                break;
                            case "ChecklistGoal":
                                int requiredCompletions = int.Parse(details[2]);
                                int bonusPoints = int.Parse(details[3]);
                                goals.Add(new ChecklistGoal(name, points, requiredCompletions, bonusPoints));
                                break;
                            default:
                                Console.WriteLine($"Unknown goal type: {goalType}");
                                break;
                        }
                    }
                    else if (line.StartsWith("TotalScore:"))
                    {
                        totalScore = int.Parse(line.Split(':')[1]);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}