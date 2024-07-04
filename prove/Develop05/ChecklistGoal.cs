using System;

[Serializable]
public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; }
    public int BonusPoints { get; set; }
    public int CurrentCompletions { get; private set; }

    public ChecklistGoal(string name, int points, int requiredCompletions, int bonusPoints)
        : base(name, points)
    {
        RequiredCompletions = requiredCompletions;
        BonusPoints = bonusPoints;
        CurrentCompletions = 0;
    }

    public override int RecordEvent()
    {
        CurrentCompletions++;
        if (CurrentCompletions >= RequiredCompletions)
        {
            IsComplete = true;
            return Points + BonusPoints;
        }
        return Points;
    }
}