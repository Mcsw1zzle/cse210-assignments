using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;


    public Product(string name, string productID, double ppu, int quantity)
    {
        _name = name;
        _productId = productID;
        _pricePerUnit = ppu;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _productId;
    }
}