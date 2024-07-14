using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("6788 Cedar View Ln", "Midvale", "UT", "USA");
        Customer customer1 = new Customer("Billy Bob", address1);
        Order order1 = new Order(customer1);
        order1.MakeProduct(new Product("Glow in the dark frisbee", "IPN1", 8.99, 3));
        order1.MakeProduct(new Product("Baby wipes", "IPN2", 3.99, 4));
        order1.MakeProduct(new Product("Mandaring oranges(3Lb)", "IPN3", 4.50, 2));
        order1.DisplayOrder();

        Address address2 = new Address("4556 Watery Ln", "Calgary", "AB", "Canada");
        Customer customer2 = new Customer("Mark Twain", address2);
        Order order2 = new Order(customer2);
        order2.MakeProduct(new Product("Maple syrup(500mL)", "IPN4", 7.99, 3));
        order2.MakeProduct(new Product("Hockey puck", "IPN5", 5.50, 2));
        order2.DisplayOrder();
    }
}