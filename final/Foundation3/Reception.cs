using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string type, Address address, string email) : base(title, description, date, time, type, address)
    {
        _email = email;
    }

    public string GetFullDetails()
    {
        return $"{_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.FullAddress()}\nRSVP Here: {_email}";
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