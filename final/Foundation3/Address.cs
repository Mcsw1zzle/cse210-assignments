using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zip;
    }

    public string FullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_zipCode}";
    }
}