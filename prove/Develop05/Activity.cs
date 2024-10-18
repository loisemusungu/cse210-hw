using System;
using System.Threading;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 5;

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

    public void DisplayStartingMessage()
    {
    Console.Write($"\nWelcome to the {_name}.\n\n{_description}.\n\nHow long, in seconds, would you like for your session (choose in multiples of 10)? ");
    string duration = Console.ReadLine();
    SetDuration(Convert.ToInt32(duration));
    Console.Clear();
    Console.WriteLine("Get ready...");
    }       

    public string DisplayEndingMessage()
    {
        return $"Well Done!\n\nThank you for using the {_name}. \n\nWe hope you enjoyed your {_duration} seconds of {_description}";
    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string> { "-", "\\", "|", "/", "|", "\\" };

        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(0);

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
        List<string> countDown = new List<string> { "5", "4", "3", "2", "1" };
        foreach (string i in countDown)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}