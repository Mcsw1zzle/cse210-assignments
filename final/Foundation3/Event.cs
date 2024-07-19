using System;
using System.Text.RegularExpressions;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _eventType;
    protected Address _address;

    public Event(string title, string description, string date, string time, string type, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = type;
        _address = address;
    }

    public string DisplayStandardDetails()
    {
        return $"{_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.FullAddress()}";
    }

    public string DisplayShortDescription()
    {
        return $"{_eventType}--{_title}, {_date}";
    }

}