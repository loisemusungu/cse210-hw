using System;

public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly.\n Clear your mind and focus on your breathing.");
        Console.WriteLine(DisplayStartingMessage());
        ShowSpinner();
        Console.WriteLine($"Breath in... {ShowCountDown}");
        Console.WriteLine($"Breath out... {ShowCountDown}");
        ShowSpinner();
        Console.WriteLine(DisplayEndingMessage());
    }

    public void run()
    {}
}