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

    public Activity()
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
        List<string> spinner = new List<string> { "-", "\\", "|", "/", "|" };

        foreach (string s in spinner)
        {
            Console.Write(s);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(6);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown()
    {
        for (int i = _duration ; i > 0; i--)
        {
            Thread.Sleep(1000);
        }
        if (_duration > 0)
        {
            Console.WriteLine("Well Done!");
        }
    }
}