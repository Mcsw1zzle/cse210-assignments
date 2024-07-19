using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string type, Address address, string speaker, int capacity) : base(title, description, date, time, type, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{_title}\nDescription: {_description}\nSpeaker: {_speaker}\nDate: {_date}\nTime: {_time}\nLocation: {_address.FullAddress()}\nMax seating capacity: {_capacity}";
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