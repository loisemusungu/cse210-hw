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
        Console.WriteLine("Comments: " + _comments);

    }
}