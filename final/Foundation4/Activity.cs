using System;

public abstract class Activity
{
    protected string _date;
    protected int _duration;
    protected string _type;

    public Activity(string date, int duration, string type)
    {
        _date = date;
        _duration = duration;
        _type = type;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {_type} ({_duration} min)--Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}