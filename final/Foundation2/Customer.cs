using System;

public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUS()
    {
        return _address.InUS();
    }

    public string GetCustomer()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}