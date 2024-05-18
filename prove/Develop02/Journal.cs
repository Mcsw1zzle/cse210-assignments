using System;
using System.IO;

public class FileWork
{
    public List<string> _loadedFile = new List<string>();
    public void LoadFile()
    {
        Console.Write("Which file would you like to load? ");
        string _pulledFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_pulledFile);
        
        foreach (string line in lines)
        {
            _loadedFile.Add(line);
        }
        Console.WriteLine("File loaded.");
    }
    public void LoadDisplay()
    {
        foreach (string thing in _loadedFile)
        {
            Console.WriteLine(thing);
        }
    }
}