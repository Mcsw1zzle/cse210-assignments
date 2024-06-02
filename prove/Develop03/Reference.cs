using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _oneVerse;
    private string _pluralVerse;


    public Reference(string book1, string chapter1, string singularVerse)
    {
        _book = book1;
        _chapter = chapter1;
        _oneVerse = singularVerse;
    }

    public Reference(string book2, string chapter2, string oneVerse, string pluralVerse)
    {
        _book = book2;
        _chapter = chapter2;
        _oneVerse = oneVerse;
        _pluralVerse = pluralVerse;
    }

    public string GetScriptureSingular()
    {
        string text = $"{_book} {_chapter}:{_oneVerse}";
        return text;
    }

    public string GetScripturePlural()
    {
        string pluralText = $"{_book} {_chapter}:{_oneVerse}-{_pluralVerse}";
        return pluralText;
    }
    
}