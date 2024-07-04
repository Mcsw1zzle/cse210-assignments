using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine(" ");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddGoal(goalManager);
                    break;
                case 2:
                    RecordEvent(goalManager);
                    break;
                case 3:
                    goalManager.DisplayGoals();
                    break;
                case 4:
                    goalManager.DisplayScore();
                    break;
                case 5:
                    SaveGoals(goalManager);
                    break;
                case 6:
                    LoadGoals(goalManager);
                    break;
                case 7:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddGoal(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal type (1. simple, 2. eternal, 3. checklist): ");
        string type = Console.ReadLine().ToLower();
        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.WriteLine("Enter required completions: ");
                int requiredCompletions = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(name, points, requiredCompletions, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal name to record event: ");
        string goalName = Console.ReadLine();
        goalManager.RecordEvent(goalName);
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
    }
}