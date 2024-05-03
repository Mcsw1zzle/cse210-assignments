using System;
using System.Globalization;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favNumber);

        DisplayResult(name, squaredNumber);
    }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResult(string userName, int number)
        {
            Console.WriteLine($"Brother {userName}, the square of your number is {number}");
        }
}