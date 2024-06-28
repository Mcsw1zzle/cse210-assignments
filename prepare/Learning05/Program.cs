using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("orange", 10);
        shapes.Add(square);

        Circle circle = new Circle("purple", 6); 
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("blue", 7, 9);
        shapes.Add(rectangle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }

}