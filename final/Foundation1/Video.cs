using System;

public class Video
{
    public string _title;

    public string _author;

    public int _length;

    public List<Comment> _comments = new List<Comment>(); 

    public List<Video> _videos = new List<Video>();


    public void DisplayVideo()
    {
        Console.WriteLine($"Video title: {_title}");
        Console.WriteLine($"Channel name: {_author}");
        Console.WriteLine($"Video length (in seconds): {_length}");
        Console.WriteLine(" ");
        Console.WriteLine("Comments:");

        foreach (Comment item in _comments)
        {
            item.WriteComment();
        }
    }

    public string DisplayCount()
    {
        return $"Number of comments: {_comments.Count}";
    }

    public void DisplayList()
    {
        foreach (Video item in _videos)
        {
            item.DisplayVideo();
            Console.WriteLine(item.DisplayCount());
            Console.WriteLine(" ");
        }
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment { _name = name, _text = text };
        _comments.Add(comment);
    }

}