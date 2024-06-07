using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment("Parker McBride", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Parker McBride", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Parker McBride", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}