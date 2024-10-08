using System;

public class Comment
{
    public string _name;
    public string _text;

    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"{_name}: {_text}");
        Console.WriteLine("Comments:");

        // Display each comment
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}