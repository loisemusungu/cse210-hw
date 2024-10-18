using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void run()
    {
        DisplayStartingMessage();

        ShowSpinner();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many things as you can for the following prompt:\n\n\"{prompt}\"");
        Console.WriteLine("You may begin in:");
        ShowCountDown();  // Countdown before starting to think about the prompt

        // Start accepting input from user and count items listed
        int _count = GetListFromUser();

        Console.WriteLine($"You listed {_count} items.");

        Console.WriteLine("This activity is now complete.");
        ShowSpinner();
        Console.WriteLine(DisplayEndingMessage());
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private int GetListFromUser()
    {
        List<string> list = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        Console.WriteLine("Start listing items: ");
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                list.Add(item);
            }
        }

        return list.Count;
    }
}
