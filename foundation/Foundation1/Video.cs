using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public int _comments = 0;
    
    public void Display()
    {
        Console.WriteLine($"{_title} ({_length} seconds)");

        for (int i = 0; i < _comments; i++)
        {
            Console.WriteLine("Comment: " + (i + 1));
        }

    }
}