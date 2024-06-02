using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class Scripture
{
    private string _reference;
    private List<Word> _wordList;

    public Scripture(string scripture) 
    {
        Reference refer = new Reference("John", "3", "16");
        _reference = refer.GetScriptureSingular();
        _wordList = new List<Word>();

        Console.WriteLine(_reference);


        string[] words = scripture.Split(' ');
        foreach (var word in words)
        {
            _wordList.Add(new Word(word));
        }

        Display();
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (var word in _wordList)
        {
            Console.Write(word.GetCurrent() + " ");
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < 3)
        {
            int index = random.Next(_wordList.Count);
            if (!_wordList[index].IsHidden())
            {
                _wordList[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _wordList.All(word => word.IsHidden());
    }
}
