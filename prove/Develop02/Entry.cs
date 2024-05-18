using System;

public class Prompt
{
    public List<string> _journalPrompts = new List<string>();
    public List<string> _entries = new List<string>();
    
    public void AddPrompt()
    {
        string filename = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _journalPrompts.Add(line);
        }
    }
    public string GetPrompt()
    {
        Console.Write("Type 1 to freewrite and type 2 if you need a prompt. ");
        string _freeWrite = Console.ReadLine();

        if (_freeWrite == "1")
        {
            Console.WriteLine("You may now write freely.");
            string _freeInput = Console.ReadLine();
            DateTime theCurrentTime2 = DateTime.Now;
            string dateText2 = theCurrentTime2.ToShortDateString();

            string allTogether2 = $"Date: {dateText2} -- Freewrite\n{_freeInput}";
            _entries.Add(allTogether2);
            return allTogether2;

        }
        else if (_freeWrite == "2")
        {
            Random random = new Random();
            string _randomPrompt = _journalPrompts[random.Next(0,11)];
            Console.WriteLine(_randomPrompt);
            string _userInput = Console.ReadLine();
            

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            string allTogether = $"Date: {dateText} -- {_randomPrompt} \n{_userInput}";
            Console.WriteLine(allTogether);

            _entries.Add(allTogether);

            return allTogether;
        }
        return "";
    }

    public void Display()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
    public string GetFileName()
    {
        Console.Write("Which file would you like to save this to? ");
        string fileName = Console.ReadLine();
    
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
        return "";
    }
    public void ClearEntries()
    {
        _entries.Clear();
    }
}

