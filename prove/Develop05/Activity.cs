using System;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
        
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    Activity()
    {}

    public string DisplayStartingMessage()
    {
        return $"Welcome to the {_name}.\n {_description}.\n How long, in seconds, would you like for your session?";
    }

    public string DisplayEndingMessage()
    {
        return $"Thank you for using the {_name}. We hope you enjoyed your {_duration} seconds of {_description}.";
    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string> { "[", "_", "]", "-" };

        foreach (string s in spinner)
        {
            Console.Write(s);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown()
    {}
}