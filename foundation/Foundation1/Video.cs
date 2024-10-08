using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
        Console.WriteLine($"Number of comments: {_comments.Count}"); // Display comment count

        if (_comments.Count > 0)
        {
            Console.WriteLine("Comments:");
            foreach (Comment comment in _comments)
            {
                comment.Display();
            }
        }
        else
        {
            Console.WriteLine("No comments yet.");
        }
        Console.WriteLine(); // Add a blank line for better readability
    }
}