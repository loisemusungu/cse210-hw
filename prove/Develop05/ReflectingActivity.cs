using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Reflect on a time when you felt overwhelmed.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you helped someone else.",
        "Think about something you have learned about yourself recently.",
        "Reflect on a time when you felt like giving up.",
        "Think about a mistake you have made recently",
        "Think of a time when you felt confident in yourself.",
        " Think about a challenge you are currently facing."
    };
    private List<string>_questions = new List<string>
    {
        "What did you learn from this experience?",
        "How did you feel during this experience?",
        "What did you do to overcome the challenge?",
        "How did you feel after the experience?",
        "What would you do differently next time?",
        "What strengths did you use during this experience?",
        "What did you learn about yourself?",
        "How did you feel about yourself during this experience?",
        "What did you learn about others during this experience?",
        "What did you learn about the situation?"
    };
    
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void run()
    {
        DisplayStartingMessage();

        ShowSpinner();

        // Get a random prompt and display it
        DisplayPrompt(GetRandomPrompt());

        // Get a random question and display it
        DisplayQuestions(GetRandomQuestions());

    }

    private string GetRandomPrompt()
    { 
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }

    private string GetRandomQuestions()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine("\n\nConsider the following prompt:");
        Console.WriteLine(prompt);

        // I want the user to press enter when they are ready to see the questions
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

    }

    public void DisplayQuestions(string question)
    {
        Console.WriteLine("Here are some questions to help you reflect on your experience: \n\n");
        Console.Write("You may begin in: \n\n"); 
        ShowCountDown();
        Console.WriteLine(question);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration); 
        
        Random random = new Random();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(question);
            ShowCountDown();
            if (DateTime.Now >= endTime) break;
        }

        Console.WriteLine("This activity is now complete.");
        ShowSpinner();
        Console.WriteLine(DisplayEndingMessage());
        
    }
    
}