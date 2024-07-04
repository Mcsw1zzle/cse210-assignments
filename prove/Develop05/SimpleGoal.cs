using System;

[Serializable]
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        IsComplete = true;
        return Points;
    }
}