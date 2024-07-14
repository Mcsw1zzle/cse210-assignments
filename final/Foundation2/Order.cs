using System;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost;
        if (_customer.InUS())
        {
            shippingCost = 5;
        }
        else 
        {
            shippingCost = 35;
        }
        total += shippingCost;
        return total;
    }

    public void MakeProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetShippinglabel()
    {
        return $"{_customer.GetCustomer()}\n{_customer.GetAddress().FullAddress()}";
    }

    public string GetPackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var product in _products)
        {
            labels.Add($"Product: {product.GetName()}, ID: {product.GetId()}");
        }
        return string.Join("\n", labels);
    }

    public void DisplayOrder()
    {
        Console.WriteLine("-Customer Order-\n");
        Console.WriteLine("Packing label:");
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(" ");
        Console.WriteLine("Shipping label:");
        Console.WriteLine(GetShippinglabel());
        Console.WriteLine(" ");
        Console.WriteLine("Total cost:");
        Console.WriteLine(GetTotal());
        Console.WriteLine("\n");
    }
}
    