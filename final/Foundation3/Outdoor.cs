using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string type, Address address, string weather) : base(title, description, date, time, type, address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"{_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.FullAddress()}\nProbable weather: {_weather}";
    }

    public void FullDisplay()
    {
        Console.WriteLine("Standard details:");
        Console.WriteLine(DisplayStandardDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Full details:");
        Console.WriteLine(GetFullDetails());
        Console.WriteLine(" ");
        Console.WriteLine("Short description:");
        Console.WriteLine(DisplayShortDescription());
        Console.WriteLine("----------------------------------");
    }
}