using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int duration, double laps, string type) : base(date, duration, type)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _duration * 60;
    }

    public override double GetPace()
    {
        return _duration / GetDistance();
    }
}