using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            numbers.Add(input);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count; 

        Console.WriteLine($"The average is: {average}");

        int highest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }
        Console.WriteLine($"The largest number is: {highest}");
    }
}