using System;
using System.Collections.Generic;
using System.Threading;

public class JournalActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "What are you looking forward to?",
        "What are you feeling right now?",
        "What are you worried about?",
        "What are you excited about?"
    };

    public JournalActivity()
    {
        SetName("Journal Activity");
        SetDescription("This activity will help you reflect on your thoughts and feelings by having you write about them in a journal.");
    }

    public void run()
    {
        DisplayStartingMessage();

        // Get the duration from the user
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        // Show the prompt
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        
        Console.WriteLine("\nYou have {0} seconds to write your thoughts. Start writing below:", duration);

        // Allow user to write until the time elapses
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine(); // Users can write as much as they want
        }

        Console.Clear();
        Console.WriteLine(DisplayEndingMessage());
        ShowSpinner();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Write about the following prompt:\n\n\"{prompt}\"");
    }
}
