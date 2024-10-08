using System;

public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public Entry(string promptText, string entryText)
    {
        // To exceed requirements I added time of journal entry
        _date = DateTime.Now;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}