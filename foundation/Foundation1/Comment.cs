using System;
using System.Collections.Generic;

public class Comment
{
    public string _name;
    public string _text;

    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Comments: \n {_name}: {_text} \n");
        

        // Display each comment
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}